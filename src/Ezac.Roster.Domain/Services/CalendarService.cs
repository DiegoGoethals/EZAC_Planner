using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly ICalendarRepository _calendarRepository;
        private readonly IJobRepository _jobRepository;

        public CalendarService(ICalendarRepository calendarRepository, IJobRepository jobRepository)
        {
            _calendarRepository = calendarRepository;
            _jobRepository = jobRepository;
        }

        public async Task<ResultModel<ApplicationCalendar>> AddAsync(ApplicationCalendarCreateRequestModel applicationCalendarCreateRequestModel)
        {
            //create new calendar
            var calender = new ApplicationCalendar
            {
                Id = applicationCalendarCreateRequestModel.Id,
                Name = applicationCalendarCreateRequestModel.Name,
                Created = DateTime.Now,
                Start = applicationCalendarCreateRequestModel.Start,
                End = applicationCalendarCreateRequestModel.End,
                Days = applicationCalendarCreateRequestModel.Days.ToList(),
            };

            //create new calendar
            var result = await _calendarRepository.AddAsync(calender);
            //check result of addasync
            if (result)
            {
                var createdRecord = await GetByIdAsync(calender.Id);
                return new ResultModel<ApplicationCalendar>
                {
                    IsSucces = true,
                    Value = createdRecord.Value,
                };
            }
            return new ResultModel<ApplicationCalendar>
            {
                IsSucces = false,
                Errors = new List<string> { "Calendar not created!" }
            };
        }

        public async Task<ResultModel<ApplicationCalendar>> DeleteAsync(Guid id)
        {
            //get the calendar
            var calendar = await _calendarRepository.GetByIdAsync(id);
            if (calendar == null)
            {
                return new ResultModel<ApplicationCalendar>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Calendar does not exist!" }
                };
            }

            //check result of DeleteAsync
            if (await _calendarRepository.DeleteAsync(calendar))
            {
                foreach (var day in calendar.Days)
                {
                    foreach (var period in day.DayPeriods)
                    {
                        foreach (var job in period.Jobs)
                        {
                            var result = await _jobRepository.DeleteAsync(job);
                            if (!result)
                            {
                                return new ResultModel<ApplicationCalendar>
                                {
                                    IsSucces = false,
                                    Errors = new List<string> { "Job kon niet worden verwijderd!" }
                                };
                            }
                        }
                    }
                }
                return new ResultModel<ApplicationCalendar> { IsSucces = true, };
            }

            //if not
            return new ResultModel<ApplicationCalendar>
            {
                IsSucces = false,
                Errors = new List<string> { "Kalender kon niet worden verwijderd!" }
            };
        }

        public async Task<ResultModel<ApplicationCalendar>> GetByIdAsync(Guid id)
        {
            //get the calendar
            var calendar = await _calendarRepository.GetByIdAsync(id);
            //create new resultmodel
            var eventResultModel = new ResultModel<ApplicationCalendar>();
            //check if exists
            if (calendar == null)
            {
                eventResultModel.IsSucces = false;
                eventResultModel.Errors = new List<string> { "No calendar found" };
                return eventResultModel;
            }

            //if exists
            eventResultModel.IsSucces = true;
            eventResultModel.Value = calendar;
            return eventResultModel;
        }

        public async Task<ResultModel<ApplicationCalendar>> UpdateAsync(ApplicationCalendarUpdateRequestModel applicationCalendarUpdateRequestModel)
        {
            //get the event
            var selectedCalendar = await _calendarRepository.GetByIdAsync(applicationCalendarUpdateRequestModel.Id);

            if (selectedCalendar == null)
            {
                return new ResultModel<ApplicationCalendar>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Calendar does not exist!" }
                };
            }

            //update event
            selectedCalendar.Name = applicationCalendarUpdateRequestModel.Name;
            selectedCalendar.Start = applicationCalendarUpdateRequestModel.Start;
            selectedCalendar.End = applicationCalendarUpdateRequestModel.End;
            selectedCalendar.Days = applicationCalendarUpdateRequestModel.Days.ToList();

            //check update result
            if (await _calendarRepository.UpdateAsync(selectedCalendar))
            {
                return new ResultModel<ApplicationCalendar>
                {
                    IsSucces = true,
                    Value = selectedCalendar,
                };
            }

            // if not
            return new ResultModel<ApplicationCalendar>
            {
                IsSucces = false,
                Errors = new List<string> { "Calendar update failed!" }
            };
        }

        public async Task<ResultModel<IEnumerable<ApplicationCalendar>>> GetAllAsync()
        {
            var calendars = await _calendarRepository.GetAllAsync();
            if (calendars != null)
            {
                return new ResultModel<IEnumerable<ApplicationCalendar>>
                {
                    IsSucces = true,
                    Value = calendars
                };
            }
            return new ResultModel<IEnumerable<ApplicationCalendar>>
            {
                IsSucces = false,
                Errors = new List<string>
                {
                    "No calendars found!"
                }
            };
        }
    }
}

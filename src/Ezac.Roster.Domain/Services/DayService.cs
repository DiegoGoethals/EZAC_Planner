using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services
{
    public class DayService : IDayService
    {
        private readonly IDayRepository _dayRepository;
        private readonly IJobRepository _jobRepository;

        public DayService(IDayRepository dayRepository, IJobRepository jobRepository)
        {
            _dayRepository = dayRepository;
            _jobRepository = jobRepository;
        }

        public async Task<ResultModel<bool>> ToggleAsync(Guid id)
        {
            try
            {
                // get the day
                var day = await _dayRepository.GetByIdAsync(id);

                if (day == null)
                {
                    return new ResultModel<bool>
                    {
                        IsSucces = false,
                        Value = false,
                        Errors = new List<string> { "Dag niet gevonden." }
                    };
                }

                // toggle de status
                day.IsOpen = !day.IsOpen;

                // update the day
                var updateResult = await _dayRepository.UpdateAsync(day);

                // check if the update is succesful
                // else return error
                if (updateResult)
                {
                    return new ResultModel<bool>
                    {
                        IsSucces = true,
                        Value = day.IsOpen,
                        Errors = new List<string> { "De dagstatus is succesvol gewijzigd." }
                    };
                }
                else
                {
                    return new ResultModel<bool>
                    {
                        IsSucces = false,
                        Value = false,
                        Errors = new List<string> { "Kan de dagstatus niet wijzigen." }
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResultModel<bool>
                {
                    IsSucces = false,
                    Value = false,
                    Errors = new List<string> { $"Er is een fout opgetreden: {ex.Message}" }
                };
            }
        }

        public async Task<ResultModel<Day>> AddAsync(DayCreateRequestModel dayCreateRequestModel)
        {
            var day = new Day
            {
                Id = dayCreateRequestModel.Id,
                Name = dayCreateRequestModel.Name,
                Date = dayCreateRequestModel.Date,
                IsOpen = dayCreateRequestModel.IsOpen,
                Created = DateTime.Now,
                Preferences = dayCreateRequestModel.Preferences.ToList(),
                CalendarId = dayCreateRequestModel.CalendarId,
                DayPeriods = dayCreateRequestModel.DayPeriods.ToList()
            };
            if (await _dayRepository.AddAsync(day))
            {
                return new ResultModel<Day>
                {
                    IsSucces = true,
                    Value = day
                };
            }
            else
            {
                return new ResultModel<Day>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Kan de dag niet toevoegen." }
                };
            }
        }

        public async Task<ResultModel<Day>> GetByIdAsync(Guid id)
        {
            var day = await _dayRepository.GetByIdAsync(id);
            if (day != null)
            {
                return new ResultModel<Day>
                {
                    IsSucces = true,
                    Value = day,
                };
            }
            else
            {
                return new ResultModel<Day>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Dag niet gevonden." }
                };
            }
        }

        public async Task<ResultModel<Day>> UpdateAsync(DayUpdateRequestModel dayUpdateRequestModel)
        {
            var day = await _dayRepository.GetByIdAsync(dayUpdateRequestModel.Id);
            if (day == null)
            {
                return new ResultModel<Day>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Dag niet gevonden." }
                };
            }

            day.Name = dayUpdateRequestModel.Name;
            day.Date = dayUpdateRequestModel.Date;
            day.IsOpen = dayUpdateRequestModel.IsOpen;
            day.Preferences = dayUpdateRequestModel.Preferences.ToList();
            day.CalendarId = dayUpdateRequestModel.CalendarId;
            day.DayPeriods = dayUpdateRequestModel.DayPeriods.ToList();

            if (await _dayRepository.UpdateAsync(day))
            {
                return new ResultModel<Day>
                {
                    IsSucces = true,
                    Value = day
                };
            }
            else
            {
                return new ResultModel<Day>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Kan de dag niet updaten." }
                };
            }
        }

        public async Task<ResultModel<Day>> DeleteAsync(Guid id)
        {
            var day = await _dayRepository.GetByIdAsync(id);
            if (day != null)
            {
                var result = await _dayRepository.DeleteAsync(day);
                if (result)
                {
                    foreach (var period in day.DayPeriods)
                    {
                        foreach (var job in period.Jobs)
                        {
                            var deleteResult = await _jobRepository.DeleteAsync(job);
                            if (!deleteResult)
                            {
                                return new ResultModel<Day>
                                {
                                    IsSucces = false,
                                    Errors = new List<string> { $"Dagdeel {period} kon niet verwijdert worden!" }
                                };
                            }
                        }
                    }
                    return new ResultModel<Day>
                    {
                        IsSucces = true,
                        Value = day,
                    };
                }
            }
            return new ResultModel<Day>
            {
                IsSucces = false,
                Errors = new List<string> { "Dag kon niet verwijdert worden!" }
            };
        }
    }
}

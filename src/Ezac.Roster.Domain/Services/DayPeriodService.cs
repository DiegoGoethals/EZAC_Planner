﻿using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Interfaces.Services;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services
{
    public class DayPeriodService : IDayPeriodService
    {
        private readonly IDayperiodRepository _dayPeriodRepository;
        private readonly IDayRepository _dayRepository;
        private readonly IJobRepository _jobRepository;

        public DayPeriodService(IDayperiodRepository dayPeriodRepository, IDayRepository dayRepository, IJobRepository jobRepository)
        {
            _dayPeriodRepository = dayPeriodRepository;
            _dayRepository = dayRepository;
            _jobRepository = jobRepository;
        }

        public async Task<ResultModel<DayPeriod>> AddAsync(DayPeriodCreateRequestModel dayPeriodCreateRequestModel)
        {
            //check if day exists
            var day = await _dayRepository.GetByIdAsync(dayPeriodCreateRequestModel.DayId);

            //check if dayperiod allrdy exist in selected day
            if (day.DayPeriods.Any(d => d.Name == dayPeriodCreateRequestModel.Name))
            {
                return new ResultModel<DayPeriod>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Dagdeel bestaat al"}
                };
            }

            //create new dayperiod
            var dayPeriod = new DayPeriod
            {
                Id = dayPeriodCreateRequestModel.Id,
                Name = dayPeriodCreateRequestModel.Name,
                IsOpen = dayPeriodCreateRequestModel.IsOpen,
                Start = dayPeriodCreateRequestModel.Start,
                End = dayPeriodCreateRequestModel.End,
                DayId = dayPeriodCreateRequestModel.DayId,
                Created = DateTime.Now,
                Jobs = new List<Job>(),
            };

            var result = false;
            switch (day.DayPeriods.Count())
            {
                case 3:
                    dayPeriod.Name = "D";
                    result = await _dayPeriodRepository.AddAsync(dayPeriod);
                    break;
                case 4:
                    dayPeriod.Name = "E";
                    result = await _dayPeriodRepository.AddAsync(dayPeriod);
                    break;
                default:
                    break;
            }

            //check result of addasync
            if (result)
            {
                var createdDayPeriod = await GetByIdAsync(dayPeriod.Id);
                return new ResultModel<DayPeriod>
                {
                    IsSucces = true,
                    Value = createdDayPeriod.Value,
                };
            }
            return new ResultModel<DayPeriod>
            {
                IsSucces = false,
                Errors = new List<string> { "Dagdeel kon niet gecreeërd worden!" }
            };
        }

        public async Task<ResultModel<DayPeriod>> DeleteAsync(Guid id)
        {
            //get the dayperiod
            var dayPeriod = await _dayPeriodRepository.GetByIdAsync(id);
            if(dayPeriod == null)
            {
                return new ResultModel<DayPeriod>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Dagdeel bestaat niet!"},
                };
            }

            //check result of deleteasync
            if (await _dayPeriodRepository.DeleteAsync(dayPeriod))
            {
                return new ResultModel<DayPeriod> { IsSucces = true };
            }

            //if not
            return new ResultModel<DayPeriod>
            {
                IsSucces = false,
                Errors = new List<string> { "Verwijderen is mislukt!" }
            };
        }

        public async Task<ResultModel<IEnumerable<DayPeriod>>> GetAllAsync()
        {
            var dayPeriods = await _dayPeriodRepository.GetAllAsync();
            if (dayPeriods == null)
            {
                return new ResultModel<IEnumerable<DayPeriod>>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Geen dagdelen gevonden!" }
                };
            }

            return new ResultModel<IEnumerable<DayPeriod>>
            {
                IsSucces = true,
                Value = dayPeriods
            };
        }

        public async Task<ResultModel<DayPeriod>> GetByIdAsync(Guid id)
        {
            //get the dayperiod
            var dayPeriod = await _dayPeriodRepository.GetByIdAsync(id);

            //create new resultmodel
            var resultModel = new ResultModel<DayPeriod>();
            //check if exists
            if (dayPeriod == null)
            {
                resultModel.IsSucces = false;
                resultModel.Errors = new List<string> { "Dagdeel bestaat niet!" };
                return resultModel;
            }

            //if exists
            resultModel.IsSucces = true;
            resultModel.Value = dayPeriod;
            return resultModel;
        }

        public async Task<ResultModel<bool>> ToggleAsync(Guid id)
        {
            try
            {
                // get the day period
                var day = await _dayPeriodRepository.GetByIdAsync(id);

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
                if(day.IsOpen)
                {
                    day.IsOpen = false;
                    if(day.Jobs.Count > 0)
                    {
                        foreach (var job in day.Jobs)
                        {
                            job.UserId = null;
                            await _jobRepository.UpdateAsync(job);
                        }
                    }                 
                }
                else
                {
                    day.IsOpen = true;
                }

                // update the day period
                var updateResult = await _dayPeriodRepository.UpdateAsync(day);

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

        public async Task<ResultModel<DayPeriod>> UpdateAsync(DayPeriodUpdateRequestModel dayPeriodUpdateRequestModel)
        {
            //get the event
            var selectedDayPeriod = await _dayPeriodRepository.GetByIdAsync(dayPeriodUpdateRequestModel.Id);

            if(selectedDayPeriod == null)
            {
                return new ResultModel<DayPeriod>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Dagdeel bestaat niet!" }

                };
            };

            //update event
            selectedDayPeriod.Name = dayPeriodUpdateRequestModel.Name;
            selectedDayPeriod.Start = dayPeriodUpdateRequestModel.Start;
            selectedDayPeriod.End = dayPeriodUpdateRequestModel.End;
            selectedDayPeriod.IsOpen = dayPeriodUpdateRequestModel.IsOpen;

            //check update result
            if (await _dayPeriodRepository.UpdateAsync(selectedDayPeriod))
            {
                return new ResultModel<DayPeriod>
                {
                    IsSucces = true,
                    Value = selectedDayPeriod,
                };
            }

            // if not
            return new ResultModel<DayPeriod>
            {
                IsSucces = false,
                Errors = new List<string> { "Dagdeel kon niet aangepast worden!" }
            };
        }
    }
}

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

        public DayPeriodService(IDayperiodRepository dayPeriodRepository, IDayRepository dayRepository)
        {
            _dayPeriodRepository = dayPeriodRepository;
            _dayRepository = dayRepository;
        }

        public async Task<ResultModel<DayPeriod>> AddAsync(DayPeriodCreateRequestModel dayPeriodCreateRequestModel)
        {
            //check if day exists
            var day = await _dayRepository.GetByIdAsync(dayPeriodCreateRequestModel.DayId);

            //check if dayperiod allrdy exist in selected day
            if(day.DayPeriods.Any(d => d.Name == dayPeriodCreateRequestModel.Name))
            {
                return new ResultModel<DayPeriod>
                {
                    IsSucces = false,
                    Errors = new List<string> { "Dayperiod allready exist!"},
                };
            }

            //create new dayperiod
            var dayPeriod = new DayPeriod
            {
                Id = Guid.NewGuid(),
                Name = dayPeriodCreateRequestModel.Name,
                IsOpen = dayPeriodCreateRequestModel.IsOpen,
                Start = dayPeriodCreateRequestModel.Start,
                End = dayPeriodCreateRequestModel.End,
                DayId = dayPeriodCreateRequestModel.DayId,
                Created = DateTime.Now
            };

            //Add new dayperiod to db
            var result = await _dayPeriodRepository.AddAsync(dayPeriod);

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
                Errors = new List<string> { "Dayperiod not created!" }
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
                    Errors = new List<string> { "DayPeriod does not exist!"},
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
                Errors = new List<string> { "Some error occured!" }
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
                resultModel.Errors = new List<string> { "Dayperiod does not exist" };
                return resultModel;
            }

            //if exists
            resultModel.IsSucces = true;
            resultModel.Value = dayPeriod;
            return resultModel;
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
                    Errors = new List<string> { "Dayperiod does not exists!" }
                };
            };

            //update event
            selectedDayPeriod.Id = dayPeriodUpdateRequestModel.Id;
            selectedDayPeriod.Name = dayPeriodUpdateRequestModel.Name;
            selectedDayPeriod.Updated = DateTime.Now;
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
                Errors = new List<string> { "Dayperiod update failed!" }
            };
        }
    }
}
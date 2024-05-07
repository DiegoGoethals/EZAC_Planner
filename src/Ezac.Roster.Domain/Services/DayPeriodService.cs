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
    public class DayPeriodService : IDayPeriodService
    {
        private readonly IDayperiodRepository _dayPeriodRepository;

        public DayPeriodService(IDayperiodRepository dayPeriodRepository)
        {
            _dayPeriodRepository = dayPeriodRepository;
        }

        public Task<ResultModel<DayPeriod>> AddAsync(DayPeriodCreateRequestModel dayPeriodCreateRequestModel)
        {
            throw new NotImplementedException();
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

        public Task<ResultModel<DayPeriod>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<DayPeriod>> UpdateAsync(DayPeriodUpdateRequestModel dayPeriodUpdateRequestModel)
        {
            throw new NotImplementedException();
        }
    }
}

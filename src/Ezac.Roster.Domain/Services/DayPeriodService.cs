using Ezac.Roster.Domain.Entities;
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
        public Task<ResultModel<DayPeriod>> AddAsync(DayPeriod dayPeriod)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<bool>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<DayPeriod>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<bool>> UpdateAsync(DayPeriod dayPeriod)
        {
            throw new NotImplementedException();
        }
    }
}

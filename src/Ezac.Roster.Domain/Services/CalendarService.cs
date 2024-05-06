using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Services
{
    public class CalendarService : ICalendarService
    {
        public Task<ApplicationCalendar> AddAsync(ApplicationCalendar calendar)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationCalendar> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ApplicationCalendar calendar)
        {
            throw new NotImplementedException();
        }
    }
}

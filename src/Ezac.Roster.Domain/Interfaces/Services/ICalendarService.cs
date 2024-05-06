using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface ICalendarService
    {
        Task<ApplicationCalendar> GetByIdAsync(Guid id);
        Task<ApplicationCalendar> AddAsync(ApplicationCalendar calendar);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateAsync(ApplicationCalendar calendar);
    }
}

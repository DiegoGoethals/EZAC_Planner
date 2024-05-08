using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface ICalendarService
    {
        Task<ResultModel<ApplicationCalendar>> GetByIdAsync(Guid id);
        Task<ResultModel<ApplicationCalendar>> AddAsync(ApplicationCalendarCreateRequestModel applicationCalendarCreateRequestModel);
        Task<ResultModel<ApplicationCalendar>> DeleteAsync(Guid id);
        Task<ResultModel<ApplicationCalendar>> UpdateAsync(ApplicationCalendarUpdateRequestModel applicationCalendarUpdateRequestModel);
		Task<ResultModel<IEnumerable<ApplicationCalendar>>> GetAllAsync();
    }
}

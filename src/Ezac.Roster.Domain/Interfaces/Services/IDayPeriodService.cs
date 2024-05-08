using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
	public interface IDayPeriodService
	{
		Task<ResultModel<DayPeriod>> GetByIdAsync(Guid id);
        Task<ResultModel<IEnumerable<DayPeriod>>> GetAllAsync();

        Task<ResultModel<DayPeriod>> AddAsync(DayPeriodCreateRequestModel dayPeriodCreateRequestModel);
		Task<ResultModel<DayPeriod>> DeleteAsync(Guid id);
		Task<ResultModel<DayPeriod>> UpdateAsync(DayPeriodUpdateRequestModel dayPeriodUpdateRequestModel);

	}
}

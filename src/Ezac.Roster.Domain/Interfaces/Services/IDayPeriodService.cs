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
		Task<ResultModel<DayPeriod>> AddAsync(DayPeriod dayPeriod);
		Task<ResultModel<bool>> DeleteAsync(Guid id);
		Task<ResultModel<bool>> UpdateAsync(DayPeriod dayPeriod);

	}
}

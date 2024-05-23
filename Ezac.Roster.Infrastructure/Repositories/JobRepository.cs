using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Repositories
{
	public class JobRepository : BaseRepository<Job>, IJobRepository
	{
		public JobRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Job>> logger)
			: base(applicationDbContext, logger)
		{
		}

		public async Task<IEnumerable<Job>> GetAllJobsByDayPeriodIdAsync(Guid id)
		{
			var result = await _table.Where(j => j.DayPeriodId == id).ToListAsync();
            return result;
		}
    }

		public async Task<List<Job>> GetJobsByCalendarIdAsync(Guid calendarId)
		{
			var jobs = await _applicationDbContext.Jobs
			.Include(j => j.DayPeriod)
			.ThenInclude(dp => dp.Day)
			.Where(j => j.DayPeriod.Day.CalendarId == calendarId)
			.ToListAsync();

			return jobs;
		}
	}
}

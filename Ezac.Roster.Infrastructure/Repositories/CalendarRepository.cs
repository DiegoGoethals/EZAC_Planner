using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class CalendarRepository : BaseRepository<ApplicationCalendar>, ICalendarRepository
    {
        public CalendarRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<ApplicationCalendar>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public override async Task<ApplicationCalendar> GetByIdAsync(Guid id)
        {
            return await _table
                .Include(c => c.Days)
            .ThenInclude(d => d.DayPeriods)
                .ThenInclude(dp => dp.Jobs)
        .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}

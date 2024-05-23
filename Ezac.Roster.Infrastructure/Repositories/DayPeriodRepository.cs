using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class DayPeriodRepository : BaseRepository<DayPeriod>, IDayperiodRepository
    {
        public DayPeriodRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<DayPeriod>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public override async Task<DayPeriod> GetByIdAsync(Guid id)
        {
            return await _table.Include(dp => dp.Preferences).FirstOrDefaultAsync(dp => dp.Id == id);
        }

        public override async Task<IEnumerable<DayPeriod>> GetAllAsync()
        {
            return await _table.Include(dp => dp.Preferences).ToListAsync();
        }
    }
}

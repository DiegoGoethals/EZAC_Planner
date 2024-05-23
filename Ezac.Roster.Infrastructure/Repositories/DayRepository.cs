using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class DayRepository : BaseRepository<Day>, IDayRepository
    {
        public DayRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Day>> logger) 
            : base(applicationDbContext, logger)
        {
        }

        public override async Task<Day> GetByIdAsync(Guid id)
        {
            return await _table.Include(d => d.Preferences).Include(d => d.DayPeriods).FirstOrDefaultAsync(d => d.Id == id);
        }

        public override async Task<IEnumerable<Day>> GetAllAsync()
        {
            return await _table.Include(d => d.Preferences).Include(d => d.DayPeriods).ToListAsync();
        }
    }
}

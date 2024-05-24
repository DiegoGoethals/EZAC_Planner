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
    public class PreferenceRepository : BaseRepository<Preference>, IPreferenceRepository
    {
        public PreferenceRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Preference>> logger)
            : base(applicationDbContext, logger)
        {
        }

        public override async Task<IEnumerable<Preference>> GetAllAsync()
        {
            return await _table.Include(p => p.DayPeriod).ToListAsync();
        }

        public override async Task<Preference> GetByIdAsync(Guid id)
        {
            return await _table.Include(p => p.DayPeriod).FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}

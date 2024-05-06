using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.Extensions.Logging;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class DayPeriodRepository : BaseRepository<DayPeriod>, IDayperiodRepository
    {
        public DayPeriodRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<DayPeriod>> logger)
            : base(applicationDbContext, logger)
        {
        }
    }
}

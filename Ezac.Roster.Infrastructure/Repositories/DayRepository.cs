using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.Extensions.Logging;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class DayRepository : BaseRepository<Day>, IDayRepository
    {
        public DayRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Day>> logger) 
            : base(applicationDbContext, logger)
        {
        }
    }
}

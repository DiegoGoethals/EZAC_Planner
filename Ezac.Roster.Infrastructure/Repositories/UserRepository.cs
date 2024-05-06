using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<User>> logger) 
            : base(applicationDbContext, logger)
        {
        }

        public async Task<IEnumerable<User>> GetByNameAsync(string name)
        {
            return await _table.Where(user => user.Name.Contains(name)).ToListAsync();
        }
    }
}

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

        public override async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _table
                .Include(u => u.UserPermissions)
                .ThenInclude(up => up.Permission)
                .Include(u => u.Jobs)
                .ToListAsync();
        }

        public async Task<IEnumerable<User>> GetByNameAsync(string name)
        {
            return await _table.Where(user => user.Name.Contains(name)).ToListAsync();
        }
    }
}

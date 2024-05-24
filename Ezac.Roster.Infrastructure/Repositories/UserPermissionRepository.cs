using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ezac.Roster.Infrastructure.Repositories
{
	public class UserPermissionRepository : BaseRepository<UserPermission>, IUserPermissionRepository
	{
		public UserPermissionRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<UserPermission>> logger) : base(applicationDbContext, logger)
		{
		}

		public async Task<IEnumerable<UserPermission>> GetAllByUserAsync(Guid userId)
		{
			return await _table.Where(up => up.UserId == userId).Include(up => up.Permission).ToListAsync();
		}

		public override async Task<IEnumerable<UserPermission>> GetAllAsync()
		{
			return await _table.Include(up => up.User).Include(up => up.Permission).ToListAsync();
		}

		public override async Task<UserPermission> GetByIdAsync(Guid id)
		{
			return await _table.Include(up => up.User).Include(up => up.Permission).FirstOrDefaultAsync(up => up.Id == id);
		}
	}
}
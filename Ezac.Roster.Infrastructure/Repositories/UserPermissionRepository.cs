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
    public class UserPermissionRepository : BaseRepository<UserPermission>, IUserPermissionRepository
    {
        public UserPermissionRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<UserPermission>> logger) : base(applicationDbContext, logger)
        {
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

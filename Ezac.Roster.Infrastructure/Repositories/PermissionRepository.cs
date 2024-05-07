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
	public class PermissionRepository: BaseRepository<Permission>, IPermissionRepository
	{
		public PermissionRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<Permission>> logger)
			: base(applicationDbContext, logger)
		{

		}

		public async Task<IEnumerable<Permission>> GetByNameAsync(string name)
		{
			return await _table.Where(permission => permission.Name.Contains(name)).ToListAsync();
		}
	}
}

﻿using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Repositories
{
    public interface IUserPermissionRepository : IBaseRepository<UserPermission>
    {
        Task<IEnumerable<UserPermission>> GetAllByUserAsync(Guid userId);
    }
}

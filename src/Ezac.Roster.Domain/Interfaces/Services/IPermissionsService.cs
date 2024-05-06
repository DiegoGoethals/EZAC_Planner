using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IPermissionsService
    {
        Task<IEnumerable<Permission>> GetAllByUserIdAsync(Guid userId);
        Task<Permission> GetByIdAsync(Guid id);
        Task AddAsync(Permission permission);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Permission permission);
        Task<IEnumerable<Permission>> SearchByNameAsync(string name);
    }
}

using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IPermissionsService
    {
        Task<ResultModel<IEnumerable<Permission>>> GetAllByUserIdAsync(Guid userId);
        Task<ResultModel<Permission>> GetByIdAsync(Guid id);
        Task<ResultModel<Permission>> AddAsync(Permission permission);
        Task<ResultModel<Permission>> DeleteAsync(Guid id);
        Task<ResultModel<Permission>> UpdateAsync(Permission permission);
        Task<ResultModel<IEnumerable<Permission>>> SearchByNameAsync(string name);
    }
}

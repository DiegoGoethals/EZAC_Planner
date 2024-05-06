using Ezac.Roster.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid id);
        Task AddAsync(User addUser);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(User updateUser);
        Task<IEnumerable<User>> SearchByNameAsync(string userName);
    }
}

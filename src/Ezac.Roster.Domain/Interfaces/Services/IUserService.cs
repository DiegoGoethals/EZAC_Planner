using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<ResultModel<IEnumerable<User>>> GetAllAsync();
        Task<ResultModel<User>> GetByIdAsync(Guid id);
        Task<ResultModel<User>> AddAsync(UserCreateRequestModel userCreateRequestModel);
        Task<ResultModel<User>> DeleteAsync(Guid id);
        Task<ResultModel<User>> UpdateAsync(UserUpdateRequestModel userUpdateRequestModel);
        Task<ResultModel<IEnumerable<User>>> SearchByNameAsync(string userName);
        Task<ResultModel<IEnumerable<User>>> GetUsersByCalendarIdAsync(Guid calendarId);
        Task<ResultModel<IEnumerable<UserPermission>>> GetUserPermissionsAsync(Guid userId);
    }
}

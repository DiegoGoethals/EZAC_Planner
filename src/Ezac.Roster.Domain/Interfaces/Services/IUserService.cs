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
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User addUser);
        void Delete(int id);
        void Update(User updateUser);
        IEnumerable<User> SearchByName(string userName);
    }
}

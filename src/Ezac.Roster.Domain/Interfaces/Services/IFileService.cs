using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IFileService
    {
        Task<string> ImportUsers(Stream fileStream);
    }
}

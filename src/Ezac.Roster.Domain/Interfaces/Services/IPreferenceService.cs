using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IPreferenceService
    {
        Task<ResultModel<IEnumerable<Preference>>> GetAllAsync();
        Task<ResultModel<Preference>> GetByIdAsync(Guid id);
        Task<ResultModel<Preference>> AddAsync(Preference preference);
        Task<ResultModel<Preference>> DeleteAsync(Guid id);
        Task<ResultModel<Preference>> UpdateAsync(Preference preference);
    }
}

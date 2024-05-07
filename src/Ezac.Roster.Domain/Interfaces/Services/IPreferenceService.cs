using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IPreferenceService
    {
        Task<ResultModel<IEnumerable<Preference>>> GetAllAsync();
        Task<ResultModel<Preference>> GetByIdAsync(Guid id);
        Task<ResultModel<Preference>> AddAsync(PreferenceCreateRequestModel preferenceCreateRequestModel);
        Task<ResultModel<Preference>> DeleteAsync(Guid id);
        Task<ResultModel<Preference>> UpdateAsync(PreferenceUpdateRequestModel preferenceUpdateRequestModel);
    }
}

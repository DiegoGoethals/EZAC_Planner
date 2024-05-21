using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IDayService
    {
        Task<ResultModel<bool>> ToggleAsync(Guid id);
        Task<ResultModel<Day>> AddAsync(DayCreateRequestModel dayCreateRequestModel);
        Task<ResultModel<Day>> GetByIdAsync(Guid id);
        Task<ResultModel<Day>> UpdateAsync(DayUpdateRequestModel dayUpdateRequestModel);
        Task<ResultModel<Day>> DeleteAsync(Guid id);
    }
}

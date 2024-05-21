using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IDayService
    {
        Task<ResultModel<bool>> ToggleAsync(Guid id);
        Task<ResultModel<Day>> AddAsync(Day day);
        Task<ResultModel<Day>> GetByIdAsync(Guid id);
        Task<ResultModel<Day>> DeleteAsync(Guid id);
    }
}

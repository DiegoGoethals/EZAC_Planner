using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Services.Models;

namespace Ezac.Roster.Domain.Interfaces.Services
{
    public interface IJobService
    {
        Task<ResultModel<IEnumerable<Job>>> GetAllAsync();
        Task<ResultModel<Job>> GetByIdAsync(Guid id);
        Task<ResultModel<Job>> AddAsync(Job job);
        Task<ResultModel<Job>> DeleteAsync(Guid id);
    }
}

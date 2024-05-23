using Ezac.Roster.Domain.Entities;

namespace Ezac.Roster.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<IEnumerable<User>> GetByNameAsync(string name);
		public Task<IEnumerable<User>> GetUsersByCalendarIdAsync(Guid calendarId);
	}
}

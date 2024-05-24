using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<IBaseRepository<T>> _logger;
        protected readonly DbSet<T> _table;

        public BaseRepository(ApplicationDbContext applicationDbContext, ILogger<IBaseRepository<T>> logger)
        {
            _applicationDbContext = applicationDbContext;
            _table = _applicationDbContext.Set<T>();
            _logger = logger;
        }

        public async Task<bool> AddAsync(T toAdd)
        {
            toAdd.Created = DateTime.Now;
            _table.Add(toAdd);
            return await SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(T toDelete)
        {
            _table.Remove(toDelete);
            return await SaveChangesAsync();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table
                .ToListAsync();
        }

        public virtual Task<T> GetByIdAsync(Guid id)
        {
            return _table
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<bool> UpdateAsync(T toUpdate)
        {
            toUpdate.Updated = DateTime.Now;
            _table.Update(toUpdate);
            return await SaveChangesAsync();
        }
        private async Task<bool> SaveChangesAsync()
        {
            try
            {
                await _applicationDbContext.SaveChangesAsync();
                return true;
            }
            
            catch(Exception exception)
            {
                _logger.LogError(exception.Message);
                return false;
            }
        }

        public async Task<bool> CheckIfExistsAsync(Guid id)
        {
            return await _table.AnyAsync(t => t.Id == id);
        }

        public async Task<bool> DeleteAllAsync()
        {
            _table.RemoveRange(await _table.ToListAsync());
            return await SaveChangesAsync();
        }
    }
}

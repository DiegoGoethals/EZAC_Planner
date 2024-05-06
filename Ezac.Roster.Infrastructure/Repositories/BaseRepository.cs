using Ezac.Roster.Domain.Entities;
using Ezac.Roster.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezac.Roster.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
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
            catch (DbUpdateException dbUpdateException)
            {
                _logger.LogError(dbUpdateException.Message);
                return false;
            }
        }

        public async Task<bool> CheckIfExistsAsync(Guid id)
        {
            return await _table.AnyAsync(t => t.Id == id);
        }
    }
}

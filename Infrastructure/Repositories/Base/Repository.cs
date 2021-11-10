using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected readonly CardTransactionDBContext _context;
        public Repository(CardTransactionDBContext context)
        {
            _context = context;
        }
        public async Task<IList<TEntity>> GetAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task InsertAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task InsertRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }

        public void Update(TEntity entityToUpdate)
        {
            _context.Set<TEntity>().Update(entityToUpdate);
        }

        public void Delete(TEntity entityToDelete)
        {
            _context.Set<TEntity>().Remove(entityToDelete);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}

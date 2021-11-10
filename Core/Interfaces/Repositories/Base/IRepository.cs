using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public Task<IList<TEntity>> GetAsync();
        public Task InsertAsync(TEntity entity);
        public void Update(TEntity entityToUpdate);
        public void Delete(TEntity entityToDeletee);
        public Task SaveChangesAsync();
        public void SaveChanges();

    }
}

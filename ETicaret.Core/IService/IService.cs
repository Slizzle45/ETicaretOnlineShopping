using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.IService
{
    public interface IService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAllQuery(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetByIdAsync(int id);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
    }
}

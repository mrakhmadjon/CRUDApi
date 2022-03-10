using CRUDApi.Models.Common;
using CRUDApi.Models.ViewModels;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRUDApi.Data.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Expression<Func<T,bool>> predicate);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null);
        Task<T> GetAsync (Expression<Func<T,bool>> predicate);

    }
}

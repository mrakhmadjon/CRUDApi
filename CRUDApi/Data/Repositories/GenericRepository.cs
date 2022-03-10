using CRUDApi.Data.Contexts;
using CRUDApi.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRUDApi.Data.Repositories
{
#pragma warning disable
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal StudentDbContext _dbContext;
        protected DbSet<T> dbSet;
        public GenericRepository(StudentDbContext studentDb)
        {
            _dbContext = studentDb;
            dbSet = studentDb.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
           var entry = dbSet.Add(entity);
             _dbContext.SaveChanges();
            return entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = dbSet.Find(predicate);
            if (entity == null)
                return false;
            dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? dbSet : dbSet.Where(predicate);
        }

        public  Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return  dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var entry = dbSet.Update(entity);
           await _dbContext.SaveChangesAsync();
            return entry.Entity;
        }
    }
}

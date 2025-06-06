using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Data_Access_Layer.Data.Context;
using Carvo.Data_Access_Layer.Repository.IGenericRepositories;
using Microsoft.EntityFrameworkCore;

namespace Carvo.Data_Access_Layer.Repository.GenericRepositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private readonly IDbContextFactory<CarvoDbContext> _contextFactory;

        public GenericRepository(IDbContextFactory<CarvoDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(TKey id)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            using var context = _contextFactory.CreateDbContext();
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null) return false;

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
            return true;
        }
    }
}

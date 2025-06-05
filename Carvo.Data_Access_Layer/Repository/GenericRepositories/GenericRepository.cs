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
        private readonly CarvoDbContext _carvoDbContext;
        public GenericRepository(CarvoDbContext carvoDbContext)
        {
            _carvoDbContext = carvoDbContext;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _carvoDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetByIdAsync(TKey id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            return await _carvoDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await _carvoDbContext.Set<TEntity>().AddAsync(entity);
            await _carvoDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _carvoDbContext.Set<TEntity>().Update(entity);
            await _carvoDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));

            var entity = await _carvoDbContext.Set<TEntity>().FindAsync(id);
            if (entity == null)
                return false;

            _carvoDbContext.Set<TEntity>().Remove(entity);
            await _carvoDbContext.SaveChangesAsync();
            return true;
        }


        //public Task<IEnumerable<TEntity>> GetAllAsync()
        //{
        //    return _carvoDbContext.Set<TEntity>().ToListAsync()
        //        .ContinueWith(task => (IEnumerable<TEntity>)task.Result);
        //}

        //public Task<TEntity?> GetByIdAsync(TKey id)
        //{
        //    if (id == null)
        //    {
        //        throw new ArgumentNullException(nameof(id), "ID cannot be null");
        //    }
        //    return _carvoDbContext.Set<TEntity>().FindAsync(id).AsTask();
        //}

        //public Task<TEntity> AddAsync(TEntity entity)
        //{
        //    if (entity == null)
        //    {
        //        throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
        //    }
        //    _carvoDbContext.Set<TEntity>().Add(entity);
        //    return _carvoDbContext.SaveChangesAsync().ContinueWith(t => entity);

        //}

        //public Task<TEntity> UpdateAsync(TEntity entity)
        //{
        //    if (entity == null)
        //    {
        //        throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
        //    }
        //    _carvoDbContext.Set<TEntity>().Update(entity);
        //    return _carvoDbContext.SaveChangesAsync().ContinueWith(t => entity);

        //}

        //public Task<bool> DeleteAsync(TKey id)
        //{
        //    if (id == null)
        //    {
        //        throw new ArgumentNullException(nameof(id), "ID cannot be null");
        //    }
        //    var entity = _carvoDbContext.Set<TEntity>().Find(id);
        //    if (entity == null)
        //    {
        //        return Task.FromResult(false);
        //    }
        //    _carvoDbContext.Set<TEntity>().Remove(entity);
        //    return _carvoDbContext.SaveChangesAsync().ContinueWith(t => true);

        //}
    }
}

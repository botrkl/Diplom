﻿using OnlineStore.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Repositories.Classes
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DataBaseContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(DataBaseContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteAsync(Guid id)
        {
            var item = await DbSet.FirstOrDefaultAsync(x => x.Id == id);
            Context.Remove(item!);
            await Context.SaveChangesAsync();
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await DbSet.FirstOrDefaultAsync(x => x.Id == id) ?? default;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var result = DbSet.Update(entity);
            await Context.SaveChangesAsync();
            return result.Entity;
        }

        public IEnumerable<TEntity?> GetAll()
        {
            return DbSet;
        }
    }
}
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity?> GetByIdAsync(Guid id);
        IEnumerable<TEntity?> GetAll();
    }
}


using Domain.Entities;

namespace Application.Services
{
    public interface IBaseService<TEntity> where TEntity: BaseEntity
    {
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<bool> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<TEntity> GetAsync(Guid Id,  CancellationToken cancellationToken = default);
        Task<TEntity> GetAllAsync(TEntity entity,  CancellationToken cancellationToken = default);
    }
}

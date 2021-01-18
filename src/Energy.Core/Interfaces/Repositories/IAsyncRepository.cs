using Energy.Core.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Energy.Core.Interfaces.Repositories
{
    public interface IAsyncRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> GetEntityById(string entityId, CancellationToken cancellationToken = default);
        Task<IEnumerable<TEntity>> GetEntitiesAsync(CancellationToken cancellationToken = default);
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}

using Energy.Core.Entities.Commerce.CatalogItems;
using Energy.Core.Interfaces.Repositories;
using Energy.Infrastructure.ModelBuilding;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Energy.Infrastructure.Repositories
{
    public class CatalogItemRepository : ICatalogItemRepository
    {
        async Task<CatalogItem> IAsyncRepository<CatalogItem>.AddAsync(CatalogItem entity, CancellationToken cancellationToken)
        {
            using var context = new CatalogContext();
            context.Add(entity);
            await context.SaveChangesAsync();
            
            return entity;
        }

        Task IAsyncRepository<CatalogItem>.DeleteAsync(CatalogItem entity, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        Task<IReadOnlyList<CatalogItem>> IAsyncRepository<CatalogItem>.GetEntitiesAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        Task<CatalogItem> IAsyncRepository<CatalogItem>.GetEntityById(string entityId, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        Task<CatalogItem> IAsyncRepository<CatalogItem>.UpdateAsync(CatalogItem entity, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}

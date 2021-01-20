using Energy.Core.Entities.CatalogItems;
using Energy.Core.Extensions.CustomTypes;
using Energy.Core.Interfaces.Repositories;
using Energy.Infrastructure.ModelBuilding;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Energy.Infrastructure.Repositories
{
    public class CatalogItemRepository : ICatalogItemRepository
    {
        async Task<CatalogItem> IAsyncRepository<CatalogItem>.AddAsync(CatalogItem entity, CancellationToken cancellationToken)
        {
            using var context = new CatalogContext();
            context.CatalogItems.Add(entity);
            await context.SaveChangesAsync();
            
            return entity;
        }

        Task ICatalogItemRepository.AddPicture(string itemid, Stream filestream, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        async Task IAsyncRepository<CatalogItem>.DeleteAsync(string entityId, CancellationToken cancellationToken)
        {
            using var context = new CatalogContext();
            CatalogItem catalogItem = context.CatalogItems.FirstOrDefault(item => item.Id == entityId);
            context.CatalogItems.Remove(catalogItem);
            await context.SaveChangesAsync();
        }

        Task IAsyncFileRepository<FileStorageInfo>.Download(FileStorageInfo file, Stream stream)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<CatalogItem>> IAsyncRepository<CatalogItem>.GetEntitiesAsync(CancellationToken cancellationToken)
        {
            using var context = new CatalogContext();
            return Task.FromResult(context.CatalogItems.AsEnumerable());
        }

        Task<CatalogItem> IAsyncRepository<CatalogItem>.GetEntityByIdAsync(string entityId, CancellationToken cancellationToken)
        {
            using var context = new CatalogContext();
            return Task.FromResult(context.CatalogItems.Find(entityId));
        }

        async Task<CatalogItem> IAsyncRepository<CatalogItem>.UpdateAsync(CatalogItem entity, CancellationToken cancellationToken)
        {
            using var context = new CatalogContext();
            CatalogItem catalogItem = context.CatalogItems.FirstOrDefault(item => item.Id == entity.Id);
            context.CatalogItems.Update(catalogItem);
            await context.SaveChangesAsync();
            return entity;
        }

        Task IAsyncFileRepository<FileStorageInfo>.Upload(FileStorageInfo file, Stream stream)
        {
            throw new System.NotImplementedException();
        }
    }
}

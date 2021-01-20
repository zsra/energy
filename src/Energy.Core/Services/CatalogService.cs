using Energy.Core.Entities.CatalogItems;
using Energy.Core.Interfaces.Repositories;
using Energy.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Energy.Core.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogItemRepository _catalogItemRepository;

        public CatalogService(ICatalogItemRepository catalogItemRepository)
            => _catalogItemRepository = catalogItemRepository;

        async Task ICatalogService.Create(CatalogItem catalogItem)
        {
            catalogItem.Id = Guid.NewGuid().ToString();
            await _catalogItemRepository.AddAsync(catalogItem);
        }

        async Task ICatalogService.Delete(string catalogItemId)
        {
            await _catalogItemRepository.DeleteAsync(catalogItemId);
        }

        async Task<CatalogItem> ICatalogService.Get(string catalogItemId)
        {
            return await _catalogItemRepository.GetEntityByIdAsync(catalogItemId);
        }

        async Task<IEnumerable<CatalogItem>> ICatalogService.GetAllCatalogItem()
        {
            return await _catalogItemRepository.GetEntitiesAsync();
        }

        async Task ICatalogService.Update(CatalogItem catalogItem)
        {
            await _catalogItemRepository.UpdateAsync(catalogItem);
        }
    }
}

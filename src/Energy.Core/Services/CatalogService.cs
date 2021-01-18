using Energy.Core.Entities.Commerce.CatalogItems;
using Energy.Core.Interfaces.Repositories;
using Energy.Core.Interfaces.Services;
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
            await _catalogItemRepository.AddAsync(catalogItem);
        }

        async Task<IEnumerable<CatalogItem>> ICatalogService.GetAllCatalogItem()
        {
            return await _catalogItemRepository.GetEntitiesAsync();
        }
    }
}

using Energy.Core.Entities.CatalogItems;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Energy.Core.Interfaces.Services
{
    public interface ICatalogService
    {
        Task Create(CatalogItem catalogItem);
        Task Update(CatalogItem catalogItem);
        Task Delete(string catalogItemId);
        Task<CatalogItem> Get(string catalogItemId);
        Task<IEnumerable<CatalogItem>> GetAllCatalogItem();
    }
}

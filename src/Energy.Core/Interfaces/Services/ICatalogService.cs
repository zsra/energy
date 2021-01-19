using Energy.Core.Entities.CatalogItems;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Energy.Core.Interfaces.Services
{
    public interface ICatalogService
    {
        Task Create(CatalogItem catalogItem);
        Task<IEnumerable<CatalogItem>> GetAllCatalogItem();
    }
}

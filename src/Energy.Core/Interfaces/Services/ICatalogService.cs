using Energy.Core.Entities.Commerce.CatalogItems;
using System.Threading.Tasks;

namespace Energy.Core.Interfaces.Services
{
    public interface ICatalogService
    {
        Task Create(CatalogItem catalogItem);
    }
}

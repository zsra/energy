using Energy.Core.Entities.Commerce.CatalogItems;
using Energy.Core.Interfaces.Commerce;

namespace Energy.Core.Extensions.Factories
{
    public enum CatalogItemType
    {
        Product,
        Service,
    }

    public class CatalogItemFactory
    {
        public ICatalogItem GetCatalogItem( CatalogItemType catalogItemType ) => catalogItemType switch
        {
            CatalogItemType.Product => new Product(),
            CatalogItemType.Service => new Service(),
            _ => throw new System.NotImplementedException(),
        };
    }
}

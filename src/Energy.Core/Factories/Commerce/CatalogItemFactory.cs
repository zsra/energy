using Energy.Core.Entities.Commerce.CatalogItems;
using Energy.Core.Interfaces;
using Energy.Core.Interfaces.Commerce;

namespace Energy.Core.Factories.Commerce
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

using Energy.Core.Entities.CatalogItems;
using Energy.Core.Interfaces;

namespace Energy.Core.Factories
{
    public enum CatalogItemType
    {
        Product,
        Service,
    }

    public class CatalogItemFactory
    {
        public ICatalogItem GetCatalogItem(CatalogItemType catalogItemType) => catalogItemType switch
        {
            CatalogItemType.Product => new Product(),
            CatalogItemType.Service => new Service(),
            _ => throw new System.NotImplementedException(),
        };
    }
}

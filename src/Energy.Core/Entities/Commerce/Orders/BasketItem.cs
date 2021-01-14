using Energy.Core.Interfaces.Commerce;

namespace Energy.Core.Entities.Commerce.Orders
{
    public class BasketItem : Entity
    {
        public ICatalogItem CatalogItem { get; set; }
        public uint Amount { get; set; }
    }
}

﻿using Energy.Core.Entities.Commerce.CatalogItems;

namespace Energy.Core.Entities.Commerce.Orders
{
    public class BasketItem : Entity
    {
        public CatalogItem CatalogItem { get; set; }
        public uint Amount { get; set; }
    }
}

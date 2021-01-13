using Energy.Core.Interfaces.Commerce;
using System;

namespace Energy.Core.Entities.Commerce.CatalogItems
{
    public class Product : Entity, ICatalogItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public string PictureUri { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? AvailableAt { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

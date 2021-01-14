using Energy.Core.Interfaces.Commerce;
using System.Collections.Generic;

namespace Energy.Core.Entities.Commerce.CatalogItems
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string ParentId { get; set; }
        public Category Parent { get; set; }
        public ICollection<Category> Children { get; set; }
        public virtual IList<ICatalogItem> CatalogItems { get; set; }
    }
}

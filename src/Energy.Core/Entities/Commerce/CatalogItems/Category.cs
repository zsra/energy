using Energy.Core.Interfaces.Commerce;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Energy.Core.Entities.Commerce.CatalogItems
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Category Parent { get; set; }
        public ICollection<Category> Children { get; set; } = new Collection<Category>();
        public virtual IList<ICatalogItem> CatalogItems { get; set; } = new List<ICatalogItem>();

        public Category(string name, string description, Category parent)
        {
            Name = name;
            Description = description;
            Parent = parent;
        }
    }
}

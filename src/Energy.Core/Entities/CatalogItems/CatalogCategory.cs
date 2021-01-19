using Energy.Core.Interfaces.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Energy.Core.Entities.CatalogItems
{
    public class CatalogCategory : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public CatalogCategory Parent { get; set; }
        public ICollection<CatalogCategory> Children { get; set; } = new Collection<CatalogCategory>();
        public virtual IList<CatalogItem> CatalogItems { get; set; } = new List<CatalogItem>();

        public CatalogCategory(string name, string description, CatalogCategory parent)
        {
            Name = name;
            Description = description;
            Parent = parent;
        }
    }
}

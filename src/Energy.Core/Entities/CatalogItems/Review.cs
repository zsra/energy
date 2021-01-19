using Energy.Core.Entities.UserManagement;
using Energy.Core.Interfaces.Entities;
using System;

namespace Energy.Core.Entities.CatalogItems
{
    public class Review : Entity
    {
        public uint Stars { get; set; }
        public DateTime? Datetime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint NumberOfUpvotes { get; set; }

        public Customer Customer { get; set; }
        public ICatalogItem CatalogItem { get; set; }
    }
}

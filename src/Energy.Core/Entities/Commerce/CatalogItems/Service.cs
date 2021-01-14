﻿using Energy.Core.Extensions.Commerce.CustomTypes;
using Energy.Core.Interfaces.Commerce;
using System;
using System.Collections.Generic;

namespace Energy.Core.Entities.Commerce.CatalogItems
{
    public class Service : Entity, ICatalogItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public IDictionary<string, string> Properties { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
using Energy.Core.Extensions.CustomTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Energy.Core.Entities.CatalogItems
{
    public class CatalogItem : Entity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
        public List<string> PictureUris { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public Weight Weight { get; set; }
        public Dimension Dimension { get; set; }
        public Dictionary<string, string> Properties { get; set; }

        public CatalogCategory Category { get; set; }
        public virtual List<Review> Reviews { get; set; } = new List<Review>();
    }
}

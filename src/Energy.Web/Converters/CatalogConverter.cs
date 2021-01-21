using Energy.Core.Entities.CatalogItems;
using Energy.Web.ViewModels;
using System.Linq;

namespace Energy.Web.Converters
{
    public static class CatalogConverter
    {
        public static CatalogItemViewModel EntityToViewModel(this CatalogItem catalogItem) 
            => new CatalogItemViewModel
        {
            Id = catalogItem.Id,
            Brand = catalogItem.Brand,
            Category = catalogItem.Category.Name,
            Name = catalogItem.Name,
            PictureUri = catalogItem.PictureUris.First(),
            Price = catalogItem.Price
        };
    }
}

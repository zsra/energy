using Energy.Core.Entities.Commerce.CatalogItems;
using Energy.Web.ViewModels;
using System.Linq;

namespace Energy.Web.Converters
{
    public static  class CatalogConverter
    {
        public static CatalogItemViewModel EntityToViewModel(CatalogItem catalogItem) => new CatalogItemViewModel
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

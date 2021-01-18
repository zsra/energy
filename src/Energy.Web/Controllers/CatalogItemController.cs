using Energy.Core.Entities.Commerce.CatalogItems;
using Energy.Core.Interfaces.Services;
using Energy.Web.Converters;
using Energy.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Energy.Web.Controllers
{
    public class CatalogItemController : ControllerBase
    {
        private readonly ILogger<CatalogItemController> _logger;
        private ICatalogService _catalogService;

        public CatalogItemController(ILogger<CatalogItemController> logger, ICatalogService catalogService)
        {
            _logger = logger;
            _catalogService = catalogService;
        }

        [HttpGet]
        public IEnumerable<CatalogItemViewModel> GetCatalog()
        {
            IEnumerable<CatalogItem> item = _catalogService.GetAllCatalogItem().Result;
            return item.Select(i => CatalogConverter.EntityToViewModel(i)).ToArray();
        }

    }
}

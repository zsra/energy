using Energy.Core.Entities.CatalogItems;
using Energy.Core.Interfaces.Services;
using Energy.Web.Converters;
using Energy.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Energy.Web.Controllers
{
    [ApiController]
    [Route("[catalog]")]
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
            IEnumerable<CatalogItem> items = _catalogService.GetAllCatalogItem().Result;
            return items.Select(i => i.EntityToViewModel()).ToArray();
        }

        [HttpPost]
        public void Create([FromBody] CatalogItem catalogItem)
        {
            _catalogService.Create(catalogItem);
        }

    }
}

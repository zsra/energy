using Energy.Core.Entities.CatalogItems;
using Energy.Core.Interfaces.Services;
using Energy.Web.Converters;
using Energy.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Energy.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ILogger<CatalogController> _logger;
        private ICatalogService _catalogService;

        public CatalogController(ILogger<CatalogController> logger, ICatalogService catalogService)
        {
            _logger = logger;
            _catalogService = catalogService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await _catalogService.GetAllCatalogItem();

            return View(new CatalogViewModel
            {
                CatalogItems = items.Select( item => item.EntityToViewModel()).ToList()
            });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CatalogItem catalogItem)
        {
            await _catalogService.Create(catalogItem);
            return RedirectToAction(nameof(Index));
        }
    }
}

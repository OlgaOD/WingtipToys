using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WingtipToys.BusinessLogic.Product;
using WingtipToys.Web.Models;

namespace WingtipToys.Web.Controllers {
    public class HomeController : ControllerBase {
        private readonly IProductQueryLogic _productQueryLogic;

        public HomeController(ILogger<ControllerBase> logger, IConfiguration configuration, IProductQueryLogic productQueryLogic) : base(logger, configuration) {
            _productQueryLogic = productQueryLogic;
        }

        public IActionResult Index() {
            int.TryParse(Configuration["DefaultCategoryId"], out var defaultCategoryId);
            var products = _productQueryLogic.GetProductsByCategoryId(defaultCategoryId);

            return View(products);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
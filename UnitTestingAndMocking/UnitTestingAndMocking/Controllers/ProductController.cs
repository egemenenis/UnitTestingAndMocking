using Microsoft.AspNetCore.Mvc;
using UnitTestingAndMocking.Services;

namespace UnitTestingAndMocking.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var count = _productService.GetProductCount();
            return View(count);
        }
    }
}

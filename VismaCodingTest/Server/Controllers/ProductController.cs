using Microsoft.AspNetCore.Mvc;
using VismaCodingTest.Server.Services.ProductRepository;

namespace VismaCodingTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var list = _productRepository.GetProducts();
            if (list == null)
                return NotFound();

            return Ok(list);
        }


    }
}

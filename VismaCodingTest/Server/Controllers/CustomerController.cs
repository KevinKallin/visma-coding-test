using Microsoft.AspNetCore.Mvc;
using VismaCodingTest.Server.Services.CustomerService;

namespace VismaCodingTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = _customerRepository.GetCustomersWithRebate();
            if (products == null)
                return NotFound();

            return Ok(products);
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetProduct(Guid customerId)
        {
            var product = _customerRepository.GetCustomer(customerId);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}

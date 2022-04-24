using VismaCodingTest.Shared;

namespace VismaCodingTest.Server.Services.CustomerService
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> _customerList = new List<Customer>()
        {
            new Customer
            {
                Id = 1,
                CustomerId = Guid.NewGuid(),
                CompanyName = "Polismyndigheten",
                ContactName = "John Doe",
                Address = "Lagerbergsgatan 35",
                City = "Uddevalla",
                PostalCode = "45132",
                Country = "Sverige",
                Phone = "+46701111111",
                Email = "john.doe@polisen.se",
                HasRebate = false
            },

             new Customer
            {
                Id = 2,
                CustomerId = Guid.Parse("75068fb8-7550-4906-aa97-4e20c2005b0f"),
                CompanyName = "Visma",
                ContactName = "Jane Doe",
                Address = "Tradenvägen 18",
                City = "Munkedal",
                PostalCode = "45591",
                Country = "Sverige",
                Phone = "+46702222222",
                Email = "jane.doe@visma.com",
                HasRebate = true
            },

              new Customer
            {
                Id = 3,
                CustomerId = Guid.Parse("e1f19d09-ab9e-4d65-8592-25fc7a6c17ca"),
                CompanyName = "Swedbank",
                ContactName = "Signe Sullysson",
                Address = "Kilbäcksgatan 13",
                City = "Uddevalla",
                PostalCode = "45130",
                Country = "Sverige",
                Phone = "+46703333333",
                Email = "signe.sullysson@swedbank.se",
                HasRebate = true
            },
        };

        public IEnumerable<Customer> GetCustomersWithRebate()
        {
            var customerWithRebate = _customerList.Where(x => x.HasRebate).ToList();
            return customerWithRebate;
        }

        public Customer GetCustomer(Guid customerId)
        {
            var customer = _customerList.Where(x => x.CustomerId == customerId).FirstOrDefault();
            return customer;
        }
    }
}

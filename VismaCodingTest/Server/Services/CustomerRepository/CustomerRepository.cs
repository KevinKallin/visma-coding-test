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
                CompanyName = "Company Name 1",
                ContactName = "John Doe",
                Address = "Testgatan 1",
                City = "Uddevalla",
                PostalCode = "45150",
                Country = "Sverige",
                Phone = "+46701111111",
                Email = "company_name1@hotmail.com",
                HasRebate = false
            },

             new Customer
            {
                Id = 2,
                CustomerId = Guid.Parse("75068fb8-7550-4906-aa97-4e20c2005b0f"),
                CompanyName = "Company Name 2",
                ContactName = "Jane Doe",
                Address = "Testgatan 25",
                City = "Uddevalla",
                PostalCode = "45150",
                Country = "Sverige",
                Phone = "+46702222222",
                Email = "company_name2@hotmail.com",
                HasRebate = true
            },

              new Customer
            {
                Id = 3,
                CustomerId = Guid.Parse("e1f19d09-ab9e-4d65-8592-25fc7a6c17ca"),
                CompanyName = "Company Name 3",
                ContactName = "Doe Jane",
                Address = "Testgatan 8C",
                City = "Uddevalla",
                PostalCode = "45150",
                Country = "Sverige",
                Phone = "+46703333333",
                Email = "company_name3@hotmail.com",
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

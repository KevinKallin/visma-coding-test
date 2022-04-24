using VismaCodingTest.Shared;

namespace VismaCodingTest.Server.Services.CustomerService
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomersWithRebate();
        Customer GetCustomer(Guid customerId);
    }
}

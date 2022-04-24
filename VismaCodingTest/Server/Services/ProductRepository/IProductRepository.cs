using VismaCodingTest.Shared;

namespace VismaCodingTest.Server.Services.ProductRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}

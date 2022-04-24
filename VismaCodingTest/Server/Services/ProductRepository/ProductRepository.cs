using VismaCodingTest.Shared;

namespace VismaCodingTest.Server.Services.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> _productList = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Title = "Trotten",
                Description = "Det här robusta skrivbordet klarar garanterat många år av kaffedrickande och hårt arbete.",
                StandardPrice = 1795.90m,
                AdjustedPrice = 1795.90m * 0.8m
            },

              new Product
            {
                Id = 2,
                Title = "Botten",
                Description = "Denna stolen kommer hjälpa att stötta din rygg med mycket stilla sittande",
                StandardPrice = 493.90m,
                AdjustedPrice = 493.90m * 0.8m
            }
        };

        public IEnumerable<Product> GetProducts()
        {
            var list = _productList.ToList();
            return list;
        }

    }
}

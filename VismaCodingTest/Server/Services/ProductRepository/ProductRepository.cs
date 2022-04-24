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
                ProductName = "Capella",
                Category = new Category()
                {
                   Id = 1,
                   Name = "Kontorsstol"
                },
                Description = "Vi har lagt in all vår kunskap i Capella. Den främjar aktivt sittande och erbjuder det bästa inom funktion, estetik och välbefinnande",
                StandardPrice = 8169.90m,
            },

            new Product
            {
                Id = 2,
                ProductName = "Claro",
                Category = new Category()
                {
                    Id = 1,
                    Name ="Kontorsstol"
                },
                Description = "Claro är en enkel och funktionell kontorsstol. Claro är en enkel och funktionell kontorsstol. Med sin ergonomiska och samtida design har den sin självklara plats i alla miljöer som kräver en flexibel och hållbar inredning",
                StandardPrice = 3059.90m,
            },

            new Product
            {
                Id = 3,
                ProductName = "Oberon Skrivbord",
                Category = new Category()
                {
                    Id = 2,
                    Name ="Skrivbord"
                },
                Description = "Oberon är vår mångsidiga skrivbordsserie med stor valfrihet i kombinationen av skivor, underreden, material och färger",
                StandardPrice = 6577.90m
            },

            new Product
            {
                Id = 4,
                ProductName = "Serie[P]",
                Category= new Category()
                {
                    Id = 2,
                    Name = "Kontorsstol"
                },
                Description = "De stabila sitt/ståborden i Serie[P] är designade för att passa dagens flexibla arbetsliv.",
                StandardPrice = 6057.90m
            }
        };

        public IEnumerable<Product> GetProducts()
        {
            return _productList.ToList();
        }

    }
}

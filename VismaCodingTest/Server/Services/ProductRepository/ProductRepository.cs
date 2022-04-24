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
                ImageUrl = "https://www.kinnarps.se/contentassets/5237728cbaa6488788c63228aa3290d7/capella-cf121-w-id281_0001.jpg",
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
                ImageUrl = "https://www.kinnarps.se/contentassets/5dcae2bf72204fef934f6debeadf0489/claro_-1.jpg?preset=product-imageLg1x",
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
                ImageUrl = "https://www.kinnarps.se/globalassets/images/product-images/oberon-gen-2/oberon-desk/product-images/19395.jpg",
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
                ImageUrl = "https://www.kinnarps.se/contentassets/696447fd4eaf4f7cb5e449809fed6ab0/kin-product-seriep-p148ssp6pt2t51t51pd1t51pd2-19702.jpg?preset=product-imageLg1x",
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

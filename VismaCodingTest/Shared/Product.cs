namespace VismaCodingTest.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal StandardPrice { get; set; }
        public decimal AdjustedPrice { get; set; }

    }
}

namespace VismaCodingTest.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Category? Category { get; set; }
        public decimal StandardPrice { get; set; }
        public decimal AdjustedPrice =>
            Math.Round(StandardPrice * 0.8M, 2);
    }
}

namespace VismaCodingTest.Shared
{
    public class Customer
    {
        public int Id { get; set; }
        public Guid CustomerId { get; set; } = Guid.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool HasRebate { get; set; }

    }
}

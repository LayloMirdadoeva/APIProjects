namespace Contracts.Responses
{
    public class SingleBrandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Address { get; set; }
        public DateTime FoundedYear { get; set; }
        public string PhoneNumber { get; set; }
    }
    }
}

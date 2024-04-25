namespace Contracts.Requests
{
    public class UpdateBrandRequest
    {
        public Guid id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime FoundedYear { get; set; }
      
    }
}

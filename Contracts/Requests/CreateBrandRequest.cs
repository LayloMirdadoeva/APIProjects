namespace Contracts.Requests
{
    public class CreateBrandRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Address { get; set; }
    }
}

namespace Contracts.Requests
{
    public class UpdateCategoryRequest
    {
        public Guid id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CategoryType { get; set; } = string.Empty;
    }
}

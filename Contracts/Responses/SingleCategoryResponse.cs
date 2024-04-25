namespace Contracts.Responses
{
    public class SingleCategoryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CategoryType { get; set; } = string.Empty;
    }
    }
}

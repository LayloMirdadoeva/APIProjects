namespace Contracts.Responses
{
    public class GetAllCategoryResponse
    {
        public IEnumerable<SingleCategoryResponse> Items { get; init; } = Enumerable.Empty<SingleCategoryResponse>();
    }
}

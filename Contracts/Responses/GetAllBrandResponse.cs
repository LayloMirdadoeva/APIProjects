namespace Contracts.Responses
{
    public class GetAllBrandResponse
    {
        public IEnumerable<SingleBrandResponse> Items { get; init; } = Enumerable.Empty<SingleBrandResponse>();
    }
}

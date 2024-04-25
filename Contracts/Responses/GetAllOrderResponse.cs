namespace Contracts.Responses
{
    public class GetAllOrderResponse
    {
        public IEnumerable<SingleOrdereResponse> Order { get; init; } = Enumerable.Empty<SingleOrdereResponse>();
    }
}

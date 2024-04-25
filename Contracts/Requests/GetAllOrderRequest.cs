using Domain.Entities;

namespace Contracts.Requests
{
    public class GetAllOrderRequest
    {
        public IEnumerable<Order> Items { get; init; } = Enumerable.Empty<Order>();
    }
}

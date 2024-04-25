using Domain.Entities;

namespace Contracts.Requests
{
    public class GetAllBrandRequest
    {
        public IEnumerable<Brand> Items { get; init; } = Enumerable.Empty<Brand>();
    }
}

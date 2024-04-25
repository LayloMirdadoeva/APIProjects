using Domain.Entities;

namespace Contracts.Requests
{
    public class GetAllCategoryRequest
    {
        public IEnumerable<Category> Items { get; init; } = Enumerable.Empty<Category>();
    }
}

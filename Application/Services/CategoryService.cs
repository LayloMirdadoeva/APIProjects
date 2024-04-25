using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class CategoryService : IBaseService<Category>
    {
        private readonly IBaseRepository<Category> _categoryRepository;

        public CategoryService(IBaseRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> CreateAsync(Category entity, CancellationToken cancellationToken = default)
        {
            return await _categoryRepository.CreateAsync(entity, cancellationToken);
        }

        public async Task<bool> DeleteAsync(Category entity, CancellationToken cancellationToken = default)
        {
            return await _categoryRepository.DeleteAsync(entity, cancellationToken);
        }

        public async Task<IEnumerable<Category>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _categoryRepository.GetAllAsync(cancellationToken);
        }

        public async  Task<Category> GetAsync(Guid Id, CancellationToken cancellationToken = default)
        {
            return await _categoryRepository.GetAsync(Id, cancellationToken);
        }

        public async Task<bool> UpdateAsync(Category entity, CancellationToken cancellationToken = default)
        {
            var exestingCategory = await GetAsync(entity.Id);

            if (exestingCategory is null)
            {
                return false;
            }
            exestingCategory.Name = entity.Name;
            exestingCategory.CategoryType = entity.CategoryType;
        
            return await _categoryRepository.UpdateAsync(exestingCategory, cancellationToken);
        }
    }
}

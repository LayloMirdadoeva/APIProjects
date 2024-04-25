using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class BrandService : IBaseService<Brand>
    {
        private readonly IBaseRepository<Brand> _brandRepository;

        public BrandService(IBaseRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task<Brand> CreateAsync(Brand entity, CancellationToken cancellationToken = default)
        {
            return await _brandRepository.CreateAsync(entity, cancellationToken);
        }

        public async Task<bool> DeleteAsync(Brand entity, CancellationToken cancellationToken = default)
        {
            return await _brandRepository.DeleteAsync(entity, cancellationToken);
        }

        public async Task<IEnumerable<Brand>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _brandRepository.GetAllAsync(cancellationToken);
        }

        public async Task<Brand> GetAsync(Guid Id, CancellationToken cancellationToken = default)
        {
            return await _brandRepository.GetAsync(Id, cancellationToken);
        }

        public async Task<bool> UpdateAsync(Brand entity, CancellationToken cancellationToken = default)
        {
            var exestingBrand = await GetAsync(entity.Id);

            if (exestingBrand is null)
            {
                return false;
            }
            exestingBrand.Name = entity.Name;
            exestingBrand.Country = entity.Country;
            exestingBrand.Address= entity.Address;
            

            return await _brandRepository.UpdateAsync(exestingBrand, cancellationToken);
        }
    }
}

using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBaseService<Brand> _BrandServise;
        private readonly IMapper _mapper;

        public BrandController(IBaseService<Brand> BrandServise, IMapper mapper)
        {
            _BrandServise = BrandServise;
            _mapper = mapper;
        }

     //   [Authorize]
        [HttpPost]
        public async Task<ActionResult<Brand>> Create([FromBody] CreateBrandRequest request, CancellationToken cancellationToken)
        {
            var Branding = _mapper.Map<Brand>(request);
            var responce = await _BrandServise.CreateAsync(Branding, cancellationToken);
            return Ok(responce);
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Brand>> GetAll(CancellationToken cancellationToken)
        {
            var Brands = await _BrandServise.GetAllAsync(cancellationToken);
            return Brands;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var Brand = await _BrandServise.GetAsync(id, cancellationToken);
            if (Brand == null)
                return NotFound();
            return Ok(Brand);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Brand>> Update([FromRoute] Guid id, [FromBody] UpdateBrandRequest request, CancellationToken cancellationToken)
        {
            var Brand = await _BrandServise.GetAsync(id, cancellationToken);
            if (Brand == null)
                return NotFound();

            _mapper.Map(request, Brand);
            await _BrandServise.UpdateAsync(Brand, cancellationToken);

            return Ok(Brand);
        }

        [HttpDelete]
        public async Task<bool> DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var Brand = await _BrandServise.GetAsync(id, cancellationToken);
            if (Brand == null)
                return false;

            await _BrandServise.DeleteAsync(Brand, cancellationToken);
            return true;
        }
    }
}

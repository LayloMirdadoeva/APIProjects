using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IBaseService<Category> _CategoryServise;
        private readonly IMapper _mapper;

        public CategoryController(IBaseService<Category> CategoryServise, IMapper mapper)
        {
            _CategoryServise = CategoryServise;
            _mapper = mapper;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Category>> Create([FromBody] CreateCategoryRequest request, CancellationToken cancellationToken)
        {
            var Categorying = _mapper.Map<Category>(request);
            var responce = await _CategoryServise.CreateAsync(Categorying, cancellationToken);
            return Ok(responce);
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Category>> GetAll(CancellationToken cancellationToken)
        {
            var Categorys = await _CategoryServise.GetAllAsync(cancellationToken);
            return Categorys;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var Category = await _CategoryServise.GetAsync(id, cancellationToken);
            if (Category == null)
                return NotFound();
            return Ok(Category);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Category>> Update([FromRoute] Guid id, [FromBody] UpdateCategoryRequest request, CancellationToken cancellationToken)
        {
            var Category = await _CategoryServise.GetAsync(id, cancellationToken);
            if (Category == null)
                return NotFound();

            _mapper.Map(request, Category);
            await _CategoryServise.UpdateAsync(Category, cancellationToken);

            return Ok(Category);
        }

        [HttpDelete]
        public async Task<bool> DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var Category = await _CategoryServise.GetAsync(id, cancellationToken);
            if (Category == null)
                return false;

            await _CategoryServise.DeleteAsync(Category, cancellationToken);
            return true;
        }
    }
}

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
    public class OrderController : ControllerBase
    {
        private readonly IBaseService<Order> _orderServise;
        private readonly IMapper _mapper;

        public OrderController(IBaseService<Order> orderServise, IMapper mapper)
        {
            _orderServise = orderServise;
            _mapper = mapper;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Order>> Create([FromBody] CreatOrderRequest request, CancellationToken cancellationToken)
        {
            var ordering = _mapper.Map<Order>(request);
            var responce = await _orderServise.CreateAsync(ordering, cancellationToken);
            return Ok(responce);
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Order>> GetAll(CancellationToken cancellationToken)
        {
            var orders = await _orderServise.GetAllAsync(cancellationToken);
            return orders;

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var order = await _orderServise.GetAsync(id, cancellationToken);
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Order>> Update([FromRoute] Guid id, [FromBody] UpdateOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _orderServise.GetAsync(id, cancellationToken);
            if (order == null)
                return NotFound();

            _mapper.Map(request, order);
            await _orderServise.UpdateAsync(order, cancellationToken);

            return Ok(order);
        }

        [HttpDelete]
        public async Task<bool> DeleteAsync([FromRoute] Guid id, CancellationToken cancellationToken)
        {
            var order = await _orderServise.GetAsync(id, cancellationToken);
            if (order == null)
                return false;

            await _orderServise.DeleteAsync(order, cancellationToken);
            return true;
        }
    }
}

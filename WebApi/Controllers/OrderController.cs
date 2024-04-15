using Application.Services;
using Contracts.Requests;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderServise;
        public OrderController(OrderService orderServise)
        {
            _orderServise = orderServise;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Create([FromBody] CreatOrderRequest request, CancellationToken cancellationToken)
        {
            var createdOrder = await _orderService.CreateAsync(request, cancellationToken);
            return Ok(createdOrder);
        }
    }
}

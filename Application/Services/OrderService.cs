using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class OrderService : IBaseService<Order>
    {

        private readonly IBaseRepository<Order> _orderRepository;

        public OrderService(IBaseRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> CreateAsync(Order order, CancellationToken token = default)
        {
            return await _orderRepository.CreateAsync(order, token);
        }

        public async Task<bool> DeleteAsync(Order order, CancellationToken token = default)
        {
            return await _orderRepository.DeleteAsync(order, token);
        }

        public async Task<IEnumerable<Order>> GetAllAsync(CancellationToken token = default)
        {
            return await _orderRepository.GetAllAsync(token);
        }

        public Task<Order> GetAllAsync(Order entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _orderRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Order order, CancellationToken token = default)
        {
            var existingOrder = await GetAsync(order.Id);

            if (existingOrder is null)
            {
                return false;
            }
            existingOrder.Products = order.Products;
            existingOrder.Quantity = order.Quantity;
            existingOrder.Amount = order.Amount;
            existingOrder.Status = order.Status;
            existingOrder.Date = order.Date;
            
            return await _orderRepository.UpdateAsync(existingOrder, token);
        }

    }
}


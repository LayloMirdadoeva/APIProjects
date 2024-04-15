using AutoMapper;
using Domain.Entities;

namespace Application.Common.Mapping;
public class OrderMapProfile : Profile
{
    public OrderMapProfile()
    {
        CreateMap<CreateOrderRequest, Order>();
        CreateMap<Order, SingleOrderResponse>();

    }
}

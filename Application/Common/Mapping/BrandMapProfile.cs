using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;

namespace Application.Common.Mapping
{
    public class BrandMapProfile : Profile
    {
        public BrandMapProfile()
        {
            CreateMap<CreateBrandRequest, Brand>();
            CreateMap<Brand, SingleBrandResponse>();
            CreateMap<GetAllBrandRequest, GetAllBrandResponse>();
            CreateMap<UpdateBrandRequest, Brand>();
        }
    }
}

using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
namespace Infrastructure.MapperProfiles;
public class InfrastructureProfile : Profile
{
    public InfrastructureProfile()
    {
        CreateMap<Order, OrderDto>().ReverseMap();
        CreateMap<CustomerDto, Customer>().ReverseMap();
    }
}
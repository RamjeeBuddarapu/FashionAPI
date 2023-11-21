using AutoMapper;
using FashionHexa.DTO;
using FashionHexa.Entities;
namespace FashionHexa.Profiles
{
    public class OrderProfile
    {
        public OrderProfile()
        {
            CreateMap<Order,OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }
    }
}

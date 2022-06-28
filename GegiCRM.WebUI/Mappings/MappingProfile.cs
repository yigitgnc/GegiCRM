using AutoMapper;
using GegiCRM.Entities.Concrete;
using GegiCRM.WebUI.Models;
using GegiCRM.WebUI.ViewComponents.UserTopNav;

namespace GegiCRM.WebUI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<AppUser, TopNavUserDto>();
            CreateMap<Product, Product>();
            CreateMap<OrdersProduct, OrdersProduct>();
        }
    }
}

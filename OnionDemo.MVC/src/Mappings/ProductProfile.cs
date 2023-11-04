using AutoMapper;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.MVC.Models;

namespace OnionDemo.MVC.src.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, ProductViewModel>().ReverseMap();
            CreateMap<ApiProductGetResponseModel, ProductViewModel>().ReverseMap();
        }
    }
}

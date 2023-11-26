using AutoMapper;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.MVC.Models;

namespace OnionDemo.MVC.src.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<ProductDto, ProductViewModel>().ReverseMap();
            this.CreateMap<ApiProductGetResponseModel, ProductViewModel>().ReverseMap();
        }
    }
}
using AutoMapper;
using OnionDemo.Application.Abstractions.Product;

namespace OnionDemo.Application.src.Product.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Domain.Product, ProductDto>().ReverseMap();
        }
    }
}
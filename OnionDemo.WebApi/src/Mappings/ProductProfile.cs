using AutoMapper;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.WebApi.Model.Product.Request;
using OnionDemo.WebApi.Model.Product.Response;

namespace OnionDemo.WebApi.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            this.CreateMap<ProductResponse, ProductDto>().ReverseMap();
            this.CreateMap<ProductCreateRequest, ProductDto>().ReverseMap();
            this.CreateMap<ProductUpdateRequest, ProductDto>().ReverseMap();
            this.CreateMap<ProductIdRequest, ProductDto>().ReverseMap();
        }
    }
}

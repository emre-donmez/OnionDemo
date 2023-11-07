using AutoMapper;
using OnionDemo.Application.Abstractions.Category;
using OnionDemo.WebApi.Model.Category.Request;
using OnionDemo.WebApi.Model.Category.Response;

namespace OnionDemo.WebApi.src.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<CategoryDto,CategoryResponse>().ReverseMap();
            this.CreateMap<CategoryDto, CategoryCreateRequest>().ReverseMap();
            this.CreateMap<CategoryDto, CategoryUpdateRequest>().ReverseMap();
        }
    }
}

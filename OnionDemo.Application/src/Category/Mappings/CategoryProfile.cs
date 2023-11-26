using AutoMapper;
using OnionDemo.Application.Abstractions.Category;

namespace OnionDemo.Application.src.Category.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Domain.Category, CategoryDto>().ReverseMap();
        }
    }
}
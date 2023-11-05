using AutoMapper;
using OnionDemo.Application.Abstractions.Category;
using OnionDemo.MVC.Models;

namespace OnionDemo.MVC.src.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<CategoryDto, ApiCategoryGetResponseModel>();
        }
    }
}

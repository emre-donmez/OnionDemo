using AutoMapper;
using OnionDemo.Application.Abstractions.Category;
using OnionDemo.Application.Generic;
using OnionDemo.Persistence.src.Context.Main;

namespace OnionDemo.Application.Category
{
    public class CategoryService : ApplicationCrudService<Domain.Category, CategoryDto>, ICategoryService
    {
        public CategoryService(MainDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
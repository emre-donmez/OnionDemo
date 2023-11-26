using OnionDemo.Application.Abstractions.src.Generic;

namespace OnionDemo.Application.Abstractions.Category
{
    public interface ICategoryService : IApplicationCrudService<Domain.Category, CategoryDto>
    {
    }
}
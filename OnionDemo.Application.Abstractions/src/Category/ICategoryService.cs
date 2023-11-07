namespace OnionDemo.Application.Abstractions.Category
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategories();
        Task<CategoryDto> Create(CategoryDto category);
        Task<CategoryDto> Update(CategoryDto category);
    }
}

namespace OnionDemo.Application.Abstractions.Category
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetCategories();
    }
}

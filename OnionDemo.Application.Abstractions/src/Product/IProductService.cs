using OnionDemo.Application.Abstractions.Product;

namespace OnionDemo.Application.Abstractions.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetProducts();
        Task<ProductDto> Create(ProductDto product);
        Task<ProductDto> Update(ProductDto product);
        Task<ProductDto> GetProductById(Guid id);
        Task<ProductDto> Disable(Guid id);
        Task<ProductDto> Enable(Guid id);
    }
}

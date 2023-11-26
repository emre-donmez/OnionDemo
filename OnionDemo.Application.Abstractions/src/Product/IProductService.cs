using OnionDemo.Application.Abstractions.Product;
using OnionDemo.Application.Abstractions.src.Generic;

namespace OnionDemo.Application.Abstractions.Services
{
    public interface IProductService : IApplicationCrudService<Domain.Product, ProductDto>
    {
        Task<List<ProductDto>> GetProducts();
    }
}
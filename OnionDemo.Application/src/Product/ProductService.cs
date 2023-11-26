using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.Application.Abstractions.Services;
using OnionDemo.Application.Generic;
using OnionDemo.Persistence.src.Context.Main;

namespace OnionDemo.Application.Product
{
    public class ProductService : ApplicationCrudService<Domain.Product, ProductDto>, IProductService
    {
        private readonly MainDbContext context;
        private readonly IMapper mapper;

        public ProductService(MainDbContext context, IMapper mapper) : base(context, mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<List<ProductDto>> GetProducts()
        {
            var products = this.context.Products.Include(p => p.Category).ToList();

            var mappingResult = this.mapper.Map<List<ProductDto>>(products);

            return Task.FromResult(mappingResult);
        }
    }
}
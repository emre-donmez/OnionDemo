using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.Application.Abstractions.Services;
using OnionDemo.Persistence.src.Context.Main;

namespace OnionDemo.Application.Product
{
    public class ProductService : IProductService
    {
        private readonly MainDbContext context;
        private readonly IMapper mapper;

        public ProductService(MainDbContext context,IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public Task<List<ProductDto>> GetProducts()
        {
            var products = this.context.Products.Include(p => p.Category).ToList();

            var mappingResult = this.mapper.Map<List<ProductDto>> (products);

            return Task.FromResult(mappingResult);
        }
        public Task<ProductDto> GetProductById(Guid id)
        {
            var product = this.context.Products.Find(id);

            var mappingResult = this.mapper.Map<ProductDto> (product);

            return Task.FromResult(mappingResult);

        }
        public Task<ProductDto> Create(ProductDto product)
        {
            product.Id = Guid.NewGuid();
            product.Created = DateTime.Now;
            product.IsDel = false;

            var mappingResult = this.mapper.Map<Domain.Product>(product);

            this.context.Products.Add(mappingResult);
            this.context.SaveChanges();

            return Task.FromResult(product);
        }

        public Task<ProductDto> Update(ProductDto product)
        {            
            var mappingResult = this.mapper.Map<Domain.Product>(product);
            
            this.context.Products.Update(mappingResult);
            this.context.SaveChanges();

            return Task.FromResult(product);
        }

        public Task<ProductDto> Disable(Guid id)
        {
            Domain.Product product = context.Products.Find(id);
            product.IsDel = true;

            context.Update(product);
            context.SaveChanges();

            var mappingResult = this.mapper.Map<ProductDto>(product);

            return Task.FromResult(mappingResult);
        }

        public Task<ProductDto> Enable(Guid id)
        {
            Domain.Product product = context.Products.Find(id);
            product.IsDel = false;
            context.Update(product);
            context.SaveChanges();

            var mappingResult = this.mapper.Map<ProductDto>(product);

            return Task.FromResult(mappingResult);
        }
    }
}

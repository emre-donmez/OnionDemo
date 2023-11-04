using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnionDemo.Application.Abstractions.Category;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.Application.Abstractions.src.Services;
using OnionDemo.Domain.Product;
using OnionDemo.Persistence.src.Context.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDemo.Application.src.Product
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

            var mappingResult = this.mapper.Map<List<Domain.Product.Product> ,List<ProductDto>> (products);

            return Task.FromResult(mappingResult);
        }
        public Task<ProductDto> GetProductById(Guid id)
        {
            var product = this.context.Products.Find(id);

            var mappingResult = this.mapper.Map<Domain.Product.Product,ProductDto> (product);

            return Task.FromResult(mappingResult);

        }
        public Task<ProductDto> Create(ProductDto product)
        {
            product.Id = Guid.NewGuid();
            product.Created = DateTime.Now;
            product.IsDel = false;

            var mappingResult = this.mapper.Map<ProductDto, Domain.Product.Product>(product);

            this.context.Products.Add(mappingResult);
            this.context.SaveChanges();

            return Task.FromResult(product);
        }

        public Task<ProductDto> Update(ProductDto product)
        {            
            var mappingResult = this.mapper.Map<ProductDto, Domain.Product.Product>(product);
            
            this.context.Products.Update(mappingResult);
            this.context.SaveChanges();

            return Task.FromResult(product);
        }

        public Task<ProductDto> Disable(Guid id)
        {
            Domain.Product.Product product = context.Products.Find(id);
            product.IsDel = true;
            context.Update(product);
            context.SaveChanges();

            var mappingResult = this.mapper.Map<Domain.Product.Product, ProductDto>(product);

            return Task.FromResult(mappingResult);
        }

        public Task<ProductDto> Enable(Guid id)
        {
            Domain.Product.Product product = context.Products.Find(id);
            product.IsDel = false;
            context.Update(product);
            context.SaveChanges();

            var mappingResult = this.mapper.Map<Domain.Product.Product, ProductDto>(product);

            return Task.FromResult(mappingResult);
        }
    }
}

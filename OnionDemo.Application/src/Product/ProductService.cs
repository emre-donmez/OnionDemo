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
        private readonly MainDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(MainDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<ProductDto>> GetProducts()
        {
            var products = _context.Products.Include(p => p.Category).ToList();

            var mappingResult = _mapper.Map<List<ProductDto>>(products);

            return Task.FromResult(mappingResult);
        }
    }
}
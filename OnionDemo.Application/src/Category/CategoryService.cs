using AutoMapper;
using OnionDemo.Application.Abstractions.Category;
using OnionDemo.Persistence.src.Context.Main;

namespace OnionDemo.Application.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly MainDbContext context;
        private readonly IMapper mapper;
        
        public CategoryService(MainDbContext context, IMapper mapper) 
        { 
            this.context = context;
            this.mapper = mapper;
        }
        public Task<List<CategoryDto>> GetCategories()
        {
            var categories = this.context.Categories.ToList();

            var mappingResult = this.mapper.Map<List<CategoryDto>>(categories);

            return Task.FromResult(mappingResult);
        }
    }
}

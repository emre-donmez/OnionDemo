using OnionDemo.Application.Abstractions.src.Category;
using OnionDemo.Persistence.src.Context.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDemo.Application.src.Category
{
    public class CategoryService : ICategoryService
    {
        public readonly MainDbContext _context;
        public CategoryService(MainDbContext context) 
        { 
            _context = context;
        }
        public List<Domain.Category.Category> GetCategories()
        {
            List<Domain.Category.Category> categories = new List<Domain.Category.Category>();
            categories = _context.Categories.ToList();
            return categories;
        }
    }
}

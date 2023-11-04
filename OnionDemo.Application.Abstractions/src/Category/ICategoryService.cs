using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDemo.Application.Abstractions.src.Category
{
    public interface ICategoryService
    {
        public List<Domain.Category.Category> GetCategories();
    }
}

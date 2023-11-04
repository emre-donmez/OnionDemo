using Microsoft.Extensions.DependencyInjection;
using OnionDemo.Application.Abstractions.src.Category;
using OnionDemo.Application.Abstractions.src.Services;
using OnionDemo.Application.src.Category;
using OnionDemo.Application.src.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionDemo.Persistence
{
    public static class ServiceRegistration
    {  
        public static void AddPersistanceServices(this IServiceCollection services) 
        {
            services.AddScoped<IProductService,ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}

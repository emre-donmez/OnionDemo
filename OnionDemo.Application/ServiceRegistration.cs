using Microsoft.Extensions.DependencyInjection;
using OnionDemo.Application.Abstractions.Category;
using OnionDemo.Application.Abstractions.Services;
using OnionDemo.Application.Abstractions.src.Generic;
using OnionDemo.Application.Category;
using OnionDemo.Application.Generic;
using OnionDemo.Application.Product;

namespace OnionDemo.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped(typeof(IApplicationCrudService<,>), typeof(ApplicationCrudService<,>));
        }
    }
}
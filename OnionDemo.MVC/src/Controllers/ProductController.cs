using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Mvc;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.MVC.Models;
using OnionDemo.MVC.src.Helpers;
namespace OnionDemo.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IApiRequestHelper apiRequestHelper;
        private readonly IMapper mapper;

        public ProductController(IMapper mapper, IApiRequestHelper apiRequestHelper)
        {
           this.apiRequestHelper = apiRequestHelper;
           this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await apiRequestHelper.GetAsync<List<ProductViewModel>>(ApiEndpoints.GetProductsEndpoint);

            var categories = await apiRequestHelper.GetAsync<List<ApiCategoryGetResponseModel>>(ApiEndpoints.GetCategoriesEndPoint);

            return View((products, categories));
        }

        [HttpPost]
        public async Task<IActionResult> Action(ProductViewModel product)
        {
            if (product.Id == Guid.Empty)            
                await apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.CreateProductEndpoint, product);            
            else            
                await apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.UpdateProductEndpoint, product);            

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Disable(Guid id)
        {
            await apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.DisableProductEndpoint, new {Id=id});

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Enable(Guid id)
        {
            await apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.EnableProductEndpoint, new { Id = id });

            return RedirectToAction("Index");
        }

    }
}

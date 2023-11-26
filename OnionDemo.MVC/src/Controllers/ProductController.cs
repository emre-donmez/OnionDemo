using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.MVC.Models;
using OnionDemo.MVC.src.Helpers;

namespace OnionDemo.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IApiRequestHelper _apiRequestHelper;
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper, IApiRequestHelper apiRequestHelper)
        {
            _apiRequestHelper = apiRequestHelper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _apiRequestHelper.GetAsync<List<ProductViewModel>>(ApiEndpoints.GetProductsEndpoint);

            var categories = await _apiRequestHelper.GetAsync<List<ApiCategoryGetResponseModel>>(ApiEndpoints.GetCategoriesEndPoint);

            return View((products, categories));
        }

        [HttpPost]
        public async Task<IActionResult> Action(ProductViewModel product)
        {
            if (product.Id == Guid.Empty)
                await _apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.CreateProductEndpoint, product);
            else
                await _apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.UpdateProductEndpoint, product);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Disable(Guid id)
        {
            await _apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.DisableProductEndpoint, new { Id = id });

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Enable(Guid id)
        {
            await _apiRequestHelper.PostAsync<ProductDto>(ApiEndpoints.EnableProductEndpoint, new { Id = id });

            return RedirectToAction("Index");
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using OnionDemo.MVC.Models;
using OnionDemo.MVC.src.Helpers;

namespace OnionDemo.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IApiRequestHelper _apiRequestHelper;

        public CategoryController(IApiRequestHelper apiRequestHelper)
        {
            _apiRequestHelper = apiRequestHelper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _apiRequestHelper.GetAsync<List<ApiCategoryGetResponseModel>>(ApiEndpoints.GetCategoriesEndPoint);
            ViewBag.CreateCategoryEndPoint = ApiEndpoints.CreateCategoryEndPoint;
            ViewBag.UpdateCategoryEndPoint = ApiEndpoints.UpdateCategoryEndPoint;
            return View(categories);
        }
    }
}
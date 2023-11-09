using Microsoft.AspNetCore.Mvc;
using OnionDemo.MVC.Models;
using OnionDemo.MVC.src.Helpers;

namespace OnionDemo.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IApiRequestHelper apiRequestHelper;
        public CategoryController(IApiRequestHelper apiRequestHelper)
        {
            this.apiRequestHelper = apiRequestHelper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await apiRequestHelper.GetAsync<List<ApiCategoryGetResponseModel>>(ApiEndpoints.GetCategoriesEndPoint);
            ViewBag.CreateCategoryEndPoint = ApiEndpoints.CreateCategoryEndPoint;
            ViewBag.UpdateCategoryEndPoint = ApiEndpoints.UpdateCategoryEndPoint;
            return View(categories);
        }
    }
}

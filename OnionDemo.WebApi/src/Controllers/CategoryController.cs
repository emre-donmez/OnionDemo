using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnionDemo.Application.Abstractions.Category;
using OnionDemo.WebApi.Model.Category.Request;
using OnionDemo.WebApi.Model.Category.Response;

namespace OnionDemo.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await categoryService.GetCategories();
            var model = mapper.Map<List<CategoryResponse>>(categories);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryCreateRequest category)
        {
            var model = this.mapper.Map<CategoryDto>(category);
            var result = await categoryService.Create(model);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] CategoryUpdateRequest category)
        {
            var model = this.mapper.Map<CategoryDto>(category);
            var result = await categoryService.Update(model);

            return Ok(result);
        }
    }
}

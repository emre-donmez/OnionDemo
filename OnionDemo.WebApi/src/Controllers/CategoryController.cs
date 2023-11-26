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
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAll();
            var model = _mapper.Map<List<CategoryResponse>>(categories);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryCreateRequest category)
        {
            var model = _mapper.Map<CategoryDto>(category);
            var result = await _categoryService.Create(model);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] CategoryUpdateRequest category)
        {
            var model = _mapper.Map<CategoryDto>(category);
            var result = await _categoryService.Update(model);

            return Ok(result);
        }
    }
}
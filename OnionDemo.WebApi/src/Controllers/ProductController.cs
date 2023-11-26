using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnionDemo.Application.Abstractions.Product;
using OnionDemo.Application.Abstractions.Services;
using OnionDemo.WebApi.Model.Product.Request;
using OnionDemo.WebApi.Model.Product.Response;

namespace OnionDemo.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productService.GetProducts();
            var model = _mapper.Map<List<ProductResponse>>(result);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetProductById([FromBody] ProductIdRequest product)
        {
            var result = await _productService.GetById(product.Id);
            var model = _mapper.Map<ProductResponse>(result);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateRequest product)
        {
            var model = _mapper.Map<ProductDto>(product);
            var result = _productService.Create(model);
            return Ok(result.Result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest product)
        {
            var model = _mapper.Map<ProductDto>(product);
            var result = _productService.Update(model);
            return Ok(result.Result);
        }

        [HttpPost]
        public async Task<IActionResult> Disable([FromBody] ProductIdRequest product)
        {
            var result = await _productService.Disable(product.Id);
            var model = _mapper.Map<ProductResponse>(result);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Enable([FromBody] ProductIdRequest product)
        {
            var result = await _productService.Enable(product.Id);
            var model = _mapper.Map<ProductResponse>(result);

            return Ok(model);
        }
    }
}
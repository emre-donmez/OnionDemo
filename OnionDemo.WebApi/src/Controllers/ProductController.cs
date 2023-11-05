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
        private readonly IProductService productService;
        private readonly IMapper mapper;


        public ProductController(IProductService productService,IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var result = await this.productService.GetProducts();
            var model = mapper.Map<List<ProductResponse>>(result);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetProductById([FromBody] ProductIdRequest product)
        {
            var result = await this.productService.GetProductById(product.Id);
            var model = mapper.Map<ProductResponse>(result);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateRequest product)
        {
            var model = mapper.Map<ProductDto>(product);
            var result = this.productService.Create(model);
            return Ok(result.Result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest product)
        {
            var model = mapper.Map<ProductDto>(product);
            var result = this.productService.Update(model);
            return Ok(result.Result);

        }

        [HttpPost]
        public async Task<IActionResult> Disable([FromBody] ProductIdRequest product)
        {
            var result = await this.productService.Disable(product.Id);
            var model = mapper.Map<ProductResponse>(result);

            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Enable([FromBody] ProductIdRequest product)
        {
            var result = await this.productService.Enable(product.Id);
            var model = mapper.Map<ProductResponse>(result);

            return Ok(model);
        }

    }
}

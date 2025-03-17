using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			return Ok(_productService.GetAll());
		}
		[HttpGet("getbyid")]
		public IActionResult Get(int productId)
		{
			var result = _productService.Get(productId);
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}
		[HttpPost("add")]
		public IActionResult Post(Product product)
		{
			return Ok(_productService.Add(product));
		}
	}
}

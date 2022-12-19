using Api_products.Handlers;
using Api_products.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductHandler _producthandler;
       
      public ProductController(IProductHandler producthandler)
        {
            _producthandler = producthandler;
        }

       [HttpPost]
        public async Task <IActionResult> Create(ProductModel model)
        {
           await _producthandler.CreateAsync(model);
            return Created("", null);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _producthandler.GetAllAsync();
            return new OkObjectResult(products);
        }
    }
}

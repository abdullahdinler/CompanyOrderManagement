using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyOrderManagementDemoV2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductManager _product;
        public ProductController(ProductManager product)
        {
            _product = product;
        }


        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product entity)
        {
            _product.Add(entity);
            return await Task.FromResult(Ok("Ürün başarılı bir şekilde eklendi."));
        }
    }
}

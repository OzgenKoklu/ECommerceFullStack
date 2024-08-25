using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;

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
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            //products/getbyid?id=1 olarak cagrilabilir
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            //postmande post - body - raw > json ile post işlevi yapiliyor 
            //{"productId":78,"categoryId":3,"productName":"HasanAHuseyin","unitsInStock":29,"unitPrice":228.0000} productID sil,otonom cunku
            //{"categoryId": 1, "productName": "dsasd","unitsInStock": 39,"unitPrice": 18.0000 }*/
            
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        /*
        [HttpGet]
        public List<Product> Get()
        {
            var result = _productService.GetAll();
            return result.Data;
        }*/

    }
}

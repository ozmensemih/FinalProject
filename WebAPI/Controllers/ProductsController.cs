using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // ATTRIBUTE  // JAVA DİLİNDE ANNOTATION
    public class ProductsController : ControllerBase
    {
        //Looseiy coupled // gevşek bağımlılık soyuta bağımlılık
        //IoC Container -- Inversion of Control // bellekteki bir yer
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger // otomatik API dökümantasyonu
            var result=_productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var resut = _productService.GetById(id);
            if (resut.Success)
            {
                return Ok(resut);
            }
            return BadRequest(resut);
        }

       [HttpPost("add")]
       public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

using EcommerceAPI.Entities;
using EcommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductRepo ProductService;

        public ProductController() 
        {
            ProductService = new ProductRepo();
        }
        
        // GET: api/<ValuesController>
        [HttpGet]
        [Route("GetProduct/{id}")]
        public ActionResult GetProduct(int id)
        {
            try
            {
                return StatusCode(200, ProductService.GetProductById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("GetProducts")]
        public ActionResult GetAllProducts()
        {
            try
            {
                return StatusCode(200, ProductService.GetAllProducts());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        [Route("AddProduct")]
        public ActionResult AddProduct([FromBody]Product product)
        {
            try
            {
                ProductService.AddProduct(product);
                return StatusCode(200, $"Added Product ${product.Pname}");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        [Route("UpdateProduct/{id}/{newPrice}")]
        public ActionResult UpdateProduct(int id, double newPrice)
        {
            try
            {
                ProductService.UpdateProduct(id, newPrice);
                return StatusCode(200, $"Product id : {id} update successfully !");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("DeleteProduct/{id}")]
        public ActionResult DeleteProduct(int id)
        {
            try
            {
                ProductService.DeleteProduct(id);
                return StatusCode(200, $"Product {id} Deleted Successfully !" );
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

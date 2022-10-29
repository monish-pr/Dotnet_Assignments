using EcommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Entities;
using EcommerceAPI.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderRepo OrderService;

        public OrderController() 
        {
            OrderService = new OrderRepo();
        }
        // POST: api/<ValuesController>
        [HttpPost]
        [Route("PlaceOrder")]
        public ActionResult PlaceOrder([FromBody]Order order)
        {
            try {
                OrderService.PlaceOrder(order);
                return StatusCode(200, "Order Placed Successfully!");
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("ViewOrders")]
        public ActionResult GetAllOrders()
        {
            try
            {   
                return StatusCode(200, OrderService.ViewAllOrders());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // GET api/<ValuesController>
        [HttpGet]
        public ActionResult GetOrderById(int id)
        {
            try
            {
                
                return StatusCode(200, OrderService.ViewOrder(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

    }
}

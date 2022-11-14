using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VM.Domain.Models;
using VM.Service.Interface;

namespace VM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CORSPolicy")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("get/{id}")]
        public IActionResult GetOrderById(Guid id)
        {
            var result = _orderService.GetOrderById(id);
            return new JsonResult(result);
        }

        [HttpPost("order-coffee")]
        public IActionResult OrderCoffee(string id)
        {
            var result = _orderService.PlaceCoffeeOrder(Guid.Parse(id));
            return new JsonResult(result);
        }

        [HttpPost("order-custom-coffee")]
        public IActionResult OrderCustomCoffee([FromBody] List<AddIngredientDto> ingredients)
        {
            var result = _orderService.PlaceCustomCoffeeOrder(ingredients);
            return new JsonResult(result);
        }
    }
}

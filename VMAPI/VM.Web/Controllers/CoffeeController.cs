using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VM.Service;

namespace VM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CORSPolicy")]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeService _coffeeService;

        public CoffeeController(ICoffeeService coffeeService)
        {
            _coffeeService = coffeeService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllCoffeeTypes()
        {
            var result = _coffeeService.GetAllCoffees();
            return new JsonResult(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetCoffeeById(Guid id)
        {
            var result = _coffeeService.GetCoffeeById(id);
            return new JsonResult(result);
        }
    }
}

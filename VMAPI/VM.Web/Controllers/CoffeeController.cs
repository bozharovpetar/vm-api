using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CORSPolicy")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("get-all")]
        public IActionResult GetAllCoffeeTypes()
        {
            return new JsonResult("VRAKJAM");
        }
    }
}

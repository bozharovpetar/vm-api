using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using VM.Service;

namespace VM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CORSPolicy")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllIngredients()
        {
            var result = _ingredientService.GetAllIngredients();
            return new JsonResult(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetIngredientId(Guid id)
        {
            var result = _ingredientService.GetIngredientById(id);
            return new JsonResult(result);
        }
    }
}

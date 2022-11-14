using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Domain.Models;

namespace VM.Service
{
    public interface IIngredientService
    {
        List<IngredientDto> GetAllIngredients();
        IngredientDto GetIngredientById(Guid id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM.Service.Interface
{
    public interface IBuilder
    {
        void SetIngredient(Guid ingredientId, int quantity);
        void SetIngredients(Guid coffeeId);
    }
}

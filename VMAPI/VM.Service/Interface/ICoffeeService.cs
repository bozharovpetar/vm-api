using VM.Domain.Models;

namespace VM.Service
{
    public interface ICoffeeService
    {
        List<CoffeeLookupDto> GetAllCoffees();
        CoffeeDto GetCoffeeById(Guid id);
    }
}

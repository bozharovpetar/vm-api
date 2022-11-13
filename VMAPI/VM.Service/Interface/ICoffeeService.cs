using VM.Domain.Models;

namespace VM.Service
{
    public interface ICoffeeService
    {
        List<CoffeeDto> GetAllCoffees();
    }
}

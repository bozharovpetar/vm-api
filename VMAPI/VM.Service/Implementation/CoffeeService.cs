using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Domain.Models;
using VM.Repository;

namespace VM.Service
{
    public class CoffeeService : ICoffeeService
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly IMapper _mapper;

        public CoffeeService(IIngredientRepository ingredientRepository, ICoffeeRepository coffeeRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository;
            _coffeeRepository = coffeeRepository;
            _mapper = mapper;
        }

        public List<CoffeeDto> GetAllCoffees()
        {
            List<CoffeeDto> result = new List<CoffeeDto>();

            var coffees = _coffeeRepository.GetAll();
            foreach(var coffee in coffees)
            {
                result.Add(_mapper.Map<CoffeeDto>(coffee));
            }

            return result;
        }
    }
}

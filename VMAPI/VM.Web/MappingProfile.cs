using AutoMapper;
using VM.Domain.Models;

namespace VM.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Coffee, CoffeeLookupDto>();
            CreateMap<Ingredient, IngredientDto>();
        }
    }
}

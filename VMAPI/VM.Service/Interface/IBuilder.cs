namespace VM.Service.Interface
{
    public interface IBuilder
    {
        void SetIngredient(Guid ingredientId, int quantity);
        void SetIngredients(Guid coffeeId);
    }
}

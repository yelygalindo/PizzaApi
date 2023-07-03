namespace Pizzas.Pizza.Interfaces
{
    public interface IRecipe
    {
        string GetDescription();
        List<string> GetIngredients();
    }
}

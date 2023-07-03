using PizzaApi.Pizza.Builder;

namespace PizzaApi.Pizza.Factory
{
    public interface IPizzaFactory
    {
        CookPizza CreatePizza(string PizzaName, List<string> CustomIngredients, string Size);
    }
}

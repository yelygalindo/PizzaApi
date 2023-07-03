using PizzaApi.Pizza;

namespace Pizzas.Pizza.Interfaces
{
    public interface IPizzaFactory
    {
        CookPizza CreatePizza(string PizzaName, List<string> CustomIngredients, string Size);
    }
}

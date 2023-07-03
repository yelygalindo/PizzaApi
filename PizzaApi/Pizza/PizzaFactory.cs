using PizzaApi.Pizza;
using Pizzas.Pizza.Builder;
using Pizzas.Pizza.Interfaces;

namespace Pizzas.Domain
{
    public class PizzaFactory : IPizzaFactory
    {

        public CookPizza CreatePizza(string PizzaName, List<string> CustomIngredients, string Size)
        {
            CookPizza pizza;
            switch (PizzaName)
            {
                case "Margherita Pizza":
                    IRecipe recipe = new MargharitaPizza();
                    pizza = CookPizza(recipe.GetIngredients(), Size, recipe.GetDescription());
                    break;
                case "Pepperoni Pizza":
                    IRecipe recipePepperoni = new PepperoniPizza();
                    pizza = CookPizza(recipePepperoni.GetIngredients(), Size, recipePepperoni.GetDescription());
                    break;
                default:
                    pizza = CookPizza(CustomIngredients, Size, "Custom");
                    break;
            }
            return pizza;
        }
        public CookPizza CookPizza(List<string> CustomIngredients, string Size, string Name)
        {
            IPizzaBuilder _pizzaBuilder = new PizzaBuilder();
            _pizzaBuilder.SetSize(Size);
            _pizzaBuilder.AddTopping(CustomIngredients);
            _pizzaBuilder.SetName(Name);
            _pizzaBuilder.AddBase();
            _pizzaBuilder.AddSauce();
            _pizzaBuilder.AddCheese();
            CookPizza pizza = _pizzaBuilder.GetPizza();
            return pizza;
        }




    }
}

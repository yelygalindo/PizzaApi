using Pizzas.Pizza.Interfaces;

namespace PizzaApi.Pizza.Recipes
{
    public class PepperoniPizza : IRecipe
    {
        public string GetDescription()
        {
            return "Pepperoni Pizza";
        }

        public List<string> GetIngredients()
        {
            List<string> list = new List<string>();
            list.Add("Peperonni");
            return list;
        }
    }
}

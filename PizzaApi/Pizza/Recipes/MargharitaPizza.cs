using PizzaApi.Pizza;
using Pizzas.Pizza.Interfaces;
using System.Xml.Linq;

namespace PizzaApi.Pizza.Recipes
{
    public class MargharitaPizza : IRecipe
    {
        public string GetDescription()
        {
            return "Margherita Pizza";
        }

        public List<string> GetIngredients()
        {
            List<string> list = new List<string>();
            list.Add("hojas de albaha");
            return list;
        }
    }
}

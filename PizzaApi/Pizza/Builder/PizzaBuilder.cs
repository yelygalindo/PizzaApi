using PizzaApi.Pizza.Builder;

namespace Pizzas.Pizza.Builder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private string _name;
        private string _size;
        private List<string> _toppings;
        private string _sauce;
        private string _cheese;
        private string _base;

        public PizzaBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _name = string.Empty;
            _size = string.Empty;
            _toppings = new List<string>();
            _sauce = string.Empty;
            _cheese = string.Empty;
            _base = string.Empty;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetSize(string size)
        {
            _size = size;
        }

        public void AddTopping(List<string> ingredients)
        {
            foreach (string topping in ingredients) {
                _toppings.Add(topping);
            }
        }

        public void AddSauce()
        {
            _sauce = "Sauce";
        }

        public void AddCheese()
        {
            _cheese = "Mozzarrella";
        }

        public CookPizza GetPizza()
        {
            CookPizza cookPizza = new(_toppings, _name);
            cookPizza.Size = _size;
            cookPizza.Base = _base;
            cookPizza.Cheese = _cheese;
            cookPizza.Sauce= _sauce;
            return cookPizza;
        }

        public void AddBase()
        {
            _base = "base with levadura";
        }
    }
}

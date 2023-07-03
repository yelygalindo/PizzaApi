namespace PizzaApi.Pizza.Builder
{
    public class CookPizza
    {
        public List<string> Ingredientes { get; }

        public string Size { get; set; }
        public string Nombre { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public string Base { get; set; }

        public CookPizza(List<string> ingredientes, string _nombre)
        {
            Ingredientes = ingredientes;
            Nombre = _nombre;
        }

        public double GetCost()
        {
            double baseCost = 10;
            double toppingCost = Ingredientes.Count * 1.50;
            double sauceCost = !string.IsNullOrEmpty(Sauce) ? 2.00 : 0.00;
            double cheeseCost = !string.IsNullOrEmpty(Cheese) ? 1.50 : 0.00;

            return baseCost + toppingCost + sauceCost + cheeseCost;
        }

        public string GetDescription()
        {
            string description = $"Pizza {Nombre} ({Size}) with {Base}, with {Cheese} cheese, {Sauce} sauce, and {string.Join(", ", Ingredientes)}";
            return description;
        }
    }
}

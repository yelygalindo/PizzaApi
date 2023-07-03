namespace PizzaApi.Controllers
{
    public class PizzaOrder
    {
        public string PizzaName { get; set; }

        public string Size { get; set; }
        public List<string> CustomIngredients { get; set; }
    }
}

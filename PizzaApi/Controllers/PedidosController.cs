using Microsoft.AspNetCore.Mvc;
using PizzaApi.Controllers.Request;
using PizzaApi.Pedido.Interfaces;
using PizzaApi.Pizza.Builder;
using PizzaApi.Pizza.Factory;

namespace PizzaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IPromocionContext _promocionContext;
        private readonly IPizzaFactory _pizzaFactory;

        public PedidosController(IPromocionContext promocionContext, IPizzaFactory pizzaFactory)
        {
            _promocionContext = promocionContext;
            _pizzaFactory = pizzaFactory;
        }

        [HttpGet]
        [Route("api/toppings")]
        public IActionResult GetAvailableToppings()
        {
            List<string> availableToppings = new()
            {
                "Pepperoni",
                "Mushrooms",
                "Albahaca",
                "Onions",
                "Green Peppers",
                "Olives"
            };
            return Ok(availableToppings);
        }

        [HttpGet]
        [Route("api/sizes")]
        public IActionResult GetAvailableSizes()
        {
            List<string> availableSizes = new()
            {
                "Personal",
                "Small",
                "Medium",
                "Familiar"
            };
            return Ok(availableSizes);
        }

        [HttpGet]
        [Route("api/recipes")]
        public IActionResult GetPredefinedRecipes()
        {
            List<string> predefinedRecipes = new()
            {
                "Margherita Pizza",
                "Pepperoni Pizza",
                "Personalize Pizza",
            };
            return Ok(predefinedRecipes);
        }

        [HttpPost("pedido")]
        public IActionResult RealizarPedido([FromBody] List<PizzaOrder> orders)
        {
            List<CookPizza> prebuiltPizzas = new();

            foreach (var order in orders)
            {
                CookPizza prebuiltPizza = _pizzaFactory.CreatePizza(order.PizzaName, order.CustomIngredients, order.Size);
                prebuiltPizzas.Add(prebuiltPizza);
            }

            var strategy = _promocionContext.GetPromotionStrategy(DateTime.Now);

            double costoTotal = 0;
            foreach (var pizza in prebuiltPizzas)
            {
                costoTotal += pizza.GetCost();
            }

            var costoDelivery = 15;
            var costoFinal = strategy.ApplyPromotion(costoTotal, costoDelivery, orders.Count);
            var orderDescriptions = prebuiltPizzas.Select(pizza => pizza.GetDescription());
            var orderCosts = prebuiltPizzas.Select(pizza => pizza.GetCost());

            var response = new
            {
                Orders = orderDescriptions,
                TotalCost = costoTotal,
                FinalCost = costoFinal
            };

            return Ok(response);
        }
    }
}

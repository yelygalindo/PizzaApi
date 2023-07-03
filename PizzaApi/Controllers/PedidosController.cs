﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult RealizarPedido([FromBody] PizzaOrder order)
        {
            CookPizza prebuiltPizza = _pizzaFactory.CreatePizza(order.PizzaName, order.CustomIngredients, order.Size);
            
            var strategy = _promocionContext.GetPromotionStrategy(DateTime.Now);
            var costoFinal = strategy.ApplyPromotion(prebuiltPizza.GetCost(), 15, 5);

            return Ok("Pedido recibido:"+ prebuiltPizza.GetDescription() + ", " + $"Cost: ${prebuiltPizza.GetCost()}" + ", "+ $"CostF: ${costoFinal}");
        }
    }
}

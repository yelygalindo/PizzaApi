# PizzaApi
  Se puede usar el metodo: GET /recipes para obtener las recetas agregadas en el sistema, la ruta sería: api/Pedidos/api/recipes.
	
  Se puede usar el metodo: GET /toppings para obtener los toppings que se pueden agregar a las pizzas, la ruta sería: api/Pedidos/api/toppings.
	
  Se puede usar el metodo: GET /sizes para obtener los tamaños disponibles de las pizzas, la ruta sería: api/Pedidos/api/sizes.
	
  Se puede usar el metodo: Post /pedido para ingresar una orden de pizza, la ruta sería: api/Pedidos/pedido. Recibe como body: 
  {
  "pizzaName": "Personalize Pizza",
  "size": "Medium",
  "customIngredients": ["Pepperoni","Olives"]
  }
    
    Otro ejemplo de uso sería:
   {
    "pizzaName": "Margherita Pizza",
    "size": "Familiar",
     "customIngredients": []
   }

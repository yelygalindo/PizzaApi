# PizzaApi
  Se puede usar el metodo: GET /recipes para obtener las recetas agregadas en el sistema, la ruta sería: api/Pedidos/api/recipes.
	
  Se puede usar el metodo: GET /toppings para obtener los toppings que se pueden agregar a las pizzas, la ruta sería: api/Pedidos/api/toppings.
	
  Se puede usar el metodo: GET /sizes para obtener los tamaños disponibles de las pizzas, la ruta sería: api/Pedidos/api/sizes.
	
  Se puede usar el metodo: Post /pedido para ingresar una orden de pizza, la ruta sería: api/Pedidos/pedido. Recibe como body: 
	 
  [
	  {
	    "PizzaName": "Personalize Pizza",
	    "Size": "Familiar",
	    "CustomIngredients": ["Pepperoni","Olives"]
	  },
      	{
	    "PizzaName": "Margherita Pizza",
	    "Size": "Familiar",
	    "CustomIngredients": []
	  }
]

Respuesta
La respuesta de la API será un objeto JSON con la siguiente estructura:

{
  "Orders": ["string"],
  "TotalCost": decimal,
  "FinalCost": decimal
}

Siendo el costo Final con el delivery incluido, en este caso el costo del delivery es de 15$ por que no era parte de la tarea el calculo según kilometraje.

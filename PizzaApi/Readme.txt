
  Se puede usar el metodo: GET /recipes para obtener las recetas agregadas en el sistema, la ruta ser�a: api/Pedidos/api/recipes
  Se puede usar el metodo: GET /toppings para obtener los toppings que se pueden agregar a las pizzas, la ruta ser�a: api/Pedidos/api/toppings
  Se puede usar el metodo: GET /sizes para obtener los tama�os disponibles de las pizzas, la ruta ser�a: api/Pedidos/api/sizes
  Se puede usar el metodo: Post /pedido para ingresar una orden de pizza, la ruta ser�a: api/Pedidos/pedido
      que recibe como body: {
                                "pizzaName": "Personalize Pizza",
                                "size": "Medium",
                                "customIngredients": ["Pepperoni","Olives"]
                            }
    Otro ejemplo de uso ser�a:
                            {
                                "pizzaName": "Margherita Pizza",
                                "size": "Familiar",
                                "customIngredients": []
                            }

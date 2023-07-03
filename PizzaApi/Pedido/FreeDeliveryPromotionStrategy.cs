using PizzaApi.Pedido.Interfaces;

namespace Pizzas.Pedido
{
    public class FreeDeliveryPromotionStrategy : IPromotionStrategy
    {
        public double ApplyPromotion(double totalAmount, double costDelivery, int cantidad)
        {            
            return totalAmount;            
        }
    }
}

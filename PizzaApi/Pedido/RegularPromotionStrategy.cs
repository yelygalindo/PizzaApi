namespace Pizzas.Pedido
{
    public class RegularPromotionStrategy : IPromotionStrategy
    {
        public double ApplyPromotion(double totalAmount, double costDelivery, int cantidad)
        {
            return totalAmount + costDelivery;
        }
    }
}

namespace Pizzas.Pedido
{
    public interface IPromotionStrategy
    {
        double ApplyPromotion(double totalAmount, double costDelivery, int cantidad);
    }
}

namespace PizzaApi.Pedido.Interfaces
{
    public interface IPromotionStrategy
    {
        double ApplyPromotion(double totalAmount, double costDelivery, int cantidad);
    }
}

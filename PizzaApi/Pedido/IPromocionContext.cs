namespace Pizzas.Pedido
{
    public interface IPromocionContext
    {
        IPromotionStrategy GetPromotionStrategy(DateTime orderDate);
        double CalculateTotalPrice(double price, double delivery, int numberOfPizzas);
    }
}

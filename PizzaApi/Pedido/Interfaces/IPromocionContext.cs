namespace PizzaApi.Pedido.Interfaces
{
    public interface IPromocionContext
    {
        IPromotionStrategy GetPromotionStrategy(DateTime orderDate);
        double CalculateTotalPrice(double price, double delivery, int numberOfPizzas);
    }
}

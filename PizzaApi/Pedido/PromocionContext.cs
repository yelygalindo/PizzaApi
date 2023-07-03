using PizzaApi.Pedido.Interfaces;

namespace Pizzas.Pedido
{
    public class PromocionContext: IPromocionContext
    {
        private readonly IPromotionStrategy promotionStrategy;

        public PromocionContext()
        {
            this.promotionStrategy = new RegularPromotionStrategy();
        }

        public IPromotionStrategy GetPromotionStrategy(DateTime orderDate)
        {
            Dictionary<DayOfWeek, IPromotionStrategy> promotionMappings = new()
            {
                { DayOfWeek.Tuesday, new TwoForOnePromotionStrategy() }, // 2x1 en martes
                { DayOfWeek.Wednesday, new TwoForOnePromotionStrategy() }, // 2x1 en miércoles
                { DayOfWeek.Thursday, new FreeDeliveryPromotionStrategy() } // Delivery gratis los jueves
            };

            if (promotionMappings.TryGetValue(orderDate.DayOfWeek, out IPromotionStrategy promotionStrategy))
                return promotionStrategy;
            
            return new RegularPromotionStrategy();
        }

        public double CalculateTotalPrice(double price, double delivery, int numberOfPizzas)
        {
            double totalPrice = promotionStrategy.ApplyPromotion(price, delivery, numberOfPizzas);
            return totalPrice;
        }
    }
}

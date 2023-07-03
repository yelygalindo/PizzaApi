using PizzaApi.Pedido.Interfaces;

namespace Pizzas.Pedido
{
    public class TwoForOnePromotionStrategy : IPromotionStrategy
    {
        public double ApplyPromotion(double totalAmount, double costDelivery, int cantidad)
        {

            int setsOfTwo = cantidad / 2; // Calcula la cantidad de conjuntos de "2x1"
            int remainder = cantidad % 2; // Calcula el sobrante (1 si hay un elemento adicional)

            totalAmount = setsOfTwo * totalAmount * 0.5; // Aplica la promoción a los conjuntos de "2x1"
            totalAmount += remainder * totalAmount; // Añade el elemento adicional si corresponde

            return totalAmount + costDelivery;
        }
    }
}

using PizzaShop.Cart;

namespace PizzaShop.Promos
{
    class FreeDeliveryPromo : IPromo
    {
        public void ApplyPromo(Order order)
        {
            order.DeliveryPrice = 0;
        }
    }
}
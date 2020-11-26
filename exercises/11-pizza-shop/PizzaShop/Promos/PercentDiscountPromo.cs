using PizzaShop.Cart;

namespace PizzaShop.Promos
{
    class PercentDiscountPromo : IPromo
    {
        private readonly int _percent;

        public PercentDiscountPromo(int percent)
        {
            // 1-100
            _percent = percent;
        }

        public void ApplyPromo(Order order)
        {
            foreach (var orderItem in order.OrderItems)
            {
                orderItem.Discount += orderItem.InitialPrice / 100 * _percent;
            }
        }
    }
}
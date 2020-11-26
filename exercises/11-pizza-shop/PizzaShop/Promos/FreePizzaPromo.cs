using System.Linq;
using PizzaShop.Cart;
using PizzaShop.Products;

namespace PizzaShop.Promos
{
    class FreePizzaPromo : IPromo
    {
        private Pizza _freePizza;

        public FreePizzaPromo(Pizza freePizza)
        {
            _freePizza = freePizza;
        }

        public void ApplyPromo(Order order)
        {
            var foundPizza = order.OrderItems
                .Where(oi => !oi.HasPromoApplied)
                .FirstOrDefault(oi => Equals(oi.Product, _freePizza));
            if (foundPizza != null)
            {
                foundPizza.Discount = foundPizza.FinalPrice;
                foundPizza.HasPromoApplied = true;
            }
        }
    }
}
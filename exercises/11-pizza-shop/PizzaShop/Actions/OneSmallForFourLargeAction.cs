using System.Linq;
using PizzaShop.Cart;
using PizzaShop.Products;

namespace PizzaShop.Actions
{
    class OneSmallForFourLargeAction : IAction
    {
        public void ApplyAction(Order order)
        {
            var largePizzas = order.OrderItems
                .Where(oi => !oi.HasPromoApplied)
                .Where(oi => oi.Product is Pizza && ((Pizza) oi.Product).Size == PizzaSize.Large)
                .ToList();
            if (largePizzas.Count < 4)
                return;

            var smallPizza = order.OrderItems
                .Where(oi => !oi.HasPromoApplied)
                .Where(oi => oi.Product is Pizza && ((Pizza) oi.Product).Size == PizzaSize.Small)
                .OrderBy(oi => oi.InitialPrice)
                .FirstOrDefault();
            if (smallPizza == null)
                return;

            largePizzas.OrderByDescending(oi => oi.InitialPrice)
                .Take(4)
                .ToList()
                .ForEach(oi => oi.HasPromoApplied = true);

            smallPizza.HasPromoApplied = true;
            smallPizza.Discount = smallPizza.InitialPrice;
        }
    }
}
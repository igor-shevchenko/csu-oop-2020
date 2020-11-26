using System.Linq;
using PizzaShop.Cart;
using PizzaShop.Products;

namespace PizzaShop.Actions
{
    class BigCompanyAction : IAction
    {
        private decimal Discount = 1000;

        public void ApplyAction(Order order)
        {
            var largePizzas = order.OrderItems
                .Where(oi => !oi.HasPromoApplied)
                .Where(oi => oi.Product is Pizza && ((Pizza) oi.Product).Size == PizzaSize.Large)
                .ToList();
            if (largePizzas.Count < 4)
                return;

            var drinks = order.OrderItems
                .Where(oi => !oi.HasPromoApplied)
                .Where(oi => oi.Product is Drink && ((Drink) oi.Product).Volume == DrinkVolume.TwoLiters)
                .ToList();
            if (drinks.Count < 8)
                return;

            largePizzas.OrderByDescending(oi => oi.InitialPrice)
                .Take(4)
                .ToList()
                .ForEach(oi => oi.HasPromoApplied = true);

            drinks.OrderByDescending(oi => oi.InitialPrice)
                .Take(8)
                .ToList()
                .ForEach(oi => oi.HasPromoApplied = true);

            order.CommonDiscount += Discount;
        }
    }
}
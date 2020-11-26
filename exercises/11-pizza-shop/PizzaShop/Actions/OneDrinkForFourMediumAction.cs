using System.Linq;
using PizzaShop.Cart;
using PizzaShop.Products;

namespace PizzaShop.Actions
{
    class OneDrinkForFourMediumAction : IAction
    {
        public void ApplyAction(Order order)
        {
            var mediumPizzas = order.OrderItems
                .Where(oi => !oi.HasPromoApplied)
                .Where(oi => oi.Product is Pizza && ((Pizza) oi.Product).Size == PizzaSize.Medium)
                .ToList();
            if (mediumPizzas.Count < 4)
                return;

            var drink = order.OrderItems
                .Where(oi => !oi.HasPromoApplied)
                .Where(oi => oi.Product is Drink && ((Drink) oi.Product).Volume == DrinkVolume.Liter)
                .OrderBy(oi => oi.InitialPrice)
                .FirstOrDefault();
            if (drink == null)
                return;

            mediumPizzas.OrderByDescending(oi => oi.InitialPrice)
                .Take(4)
                .ToList()
                .ForEach(oi => oi.HasPromoApplied = true);

            drink.HasPromoApplied = true;
            drink.Discount = drink.InitialPrice;
        }
    }
}
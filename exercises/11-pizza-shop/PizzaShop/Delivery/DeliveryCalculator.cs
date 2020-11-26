using System.Collections.Generic;
using System.Linq;
using PizzaShop.Products;

namespace PizzaShop.Delivery
{
    class DeliveryCalculator : IDeliveryCalculator
    {
        private int MinimumDrinkVolumeMl = 100 * 1000;
        private decimal DeliveryPrice = 150;
        private decimal MinimumFreeDeliveryAmount = 1000;

        public decimal GetDeliveryPrice(List<IProduct> products)
        {
            var hasEnoughDrinks = products
                                      .OfType<Drink>()
                                      .Sum(d => (int)d.Volume) >= MinimumDrinkVolumeMl;
            if (hasEnoughDrinks)
                return 0;

            var hasPizza = products.OfType<Pizza>().Any();
            if (!hasPizza)
                throw new HasNoPizzaException();

            var sum = products.Sum(p => p.Price);
            if (sum >= MinimumFreeDeliveryAmount)
                return 0;
            return DeliveryPrice;
        }
    }
}
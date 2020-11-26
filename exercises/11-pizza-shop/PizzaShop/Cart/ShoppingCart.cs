using System.Collections.Generic;
using PizzaShop.Actions;
using PizzaShop.Delivery;
using PizzaShop.Products;
using PizzaShop.Promos;

namespace PizzaShop.Cart
{
    class ShoppingCart
    {
        private IDeliveryCalculator _deliveryCalculator;
        private IActionProvider _actionProvider;

        public ShoppingCart(IDeliveryCalculator deliveryCalculator, IActionProvider actionProvider)
        {
            _deliveryCalculator = deliveryCalculator;
            _actionProvider = actionProvider;
        }

        public decimal GetTotalPrice(List<IProduct> products, bool isDelivery, List<IPromo> promoCodes)
        {
            var order = new Order(products)
            {
                DeliveryPrice = isDelivery ? _deliveryCalculator.GetDeliveryPrice(products) : 0
            };

            promoCodes.ForEach(p => p.ApplyPromo(order));
            _actionProvider.GetActiveActions().ForEach(a => a.ApplyAction(order));

            return order.GetTotalFinalPrice();
        }
    }
}
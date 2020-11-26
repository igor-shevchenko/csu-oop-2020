using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using PizzaShop.Products;

namespace PizzaShop.Cart
{
    class Order
    {
        private readonly List<OrderItem> _orderItems;

        public ReadOnlyCollection<OrderItem> OrderItems => _orderItems.AsReadOnly();
        public decimal DeliveryPrice { get; set; }
        public decimal CommonDiscount { get; set; }

        public Order(List<IProduct> products)
        {
            _orderItems = products
                .Select(p => new OrderItem(p))
                .ToList();
        }

        public decimal GetTotalFinalPrice()
        {
            return Math.Max(_orderItems.Sum(oi => oi.FinalPrice) + DeliveryPrice - CommonDiscount, 0);
        }
    }
}
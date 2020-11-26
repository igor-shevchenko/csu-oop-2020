using System;
using PizzaShop.Products;

namespace PizzaShop.Cart
{
    class OrderItem
    {
        public IProduct Product { get; }
        public decimal InitialPrice => Product.Price;
        public decimal Discount { get; set; }
        public bool HasPromoApplied { get; set; }
        public decimal FinalPrice => Math.Max(InitialPrice - Discount, 0);
    
        public OrderItem(IProduct product)
        {
            Product = product;
        }
    }
}
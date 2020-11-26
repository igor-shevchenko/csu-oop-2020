using System.Collections.Generic;
using PizzaShop.Products;

namespace PizzaShop.Delivery
{
    interface IDeliveryCalculator
    {
        decimal GetDeliveryPrice(List<IProduct> products);
    }
}
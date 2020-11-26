using PizzaShop.Cart;

namespace PizzaShop.Promos
{
    interface IPromo
    {
        void ApplyPromo(Order order);
    }
}
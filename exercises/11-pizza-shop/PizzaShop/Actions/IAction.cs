using PizzaShop.Cart;

namespace PizzaShop.Actions
{
    interface IAction
    {
        void ApplyAction(Order order);
    }
}
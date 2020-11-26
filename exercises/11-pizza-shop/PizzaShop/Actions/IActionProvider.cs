using System.Collections.Generic;

namespace PizzaShop.Actions
{
    interface IActionProvider
    {
        List<IAction> GetActiveActions();
    }
}
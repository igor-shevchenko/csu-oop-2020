using System;
using System.Collections.Generic;

namespace PizzaShop.Actions
{
    class ActionProvider : IActionProvider
    {
        public List<IAction> GetActiveActions()
        {
            var actions = new List<IAction>
            {
                new OneSmallForFourLargeAction(),
                new OneDrinkForFourMediumAction()
            };

            if (DateTime.Today == new DateTime(2020, 11, 27))
            {
                actions.Add(new BigCompanyAction());
            }

            return actions;
        }
    }
}
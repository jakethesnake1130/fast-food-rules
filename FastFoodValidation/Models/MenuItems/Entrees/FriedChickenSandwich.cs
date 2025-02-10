using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class FriedChickenSandwich : Entree
    {
        public FriedChickenSandwich()
        {
            ItemName = "Fried Chicken Sandwich";
            Price = 9.99;
            ForGlutenFree = false;
            ForPorkFree = true;
            ForVegetarian = false;
            ForDiabetic = false;
            ForLactoseIntolerant = true;
            ForVegan = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class GrilledChickenSandwich : Entree
    {
        public GrilledChickenSandwich()
        {
            ItemName = "Grilled Chicken Sandwich";
            Price = 9.99;
            ForGlutenFree = false;
            ForPorkFree = true;
            ForVegetarian = false;
            ForDiabetic = true;
            ForLactoseIntolerant = true;
            ForVegan = false;
        }
    }
}

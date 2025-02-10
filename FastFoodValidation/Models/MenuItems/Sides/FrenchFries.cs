using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Sides
{
    internal class FrenchFries : Side
    {
        public FrenchFries()
        {
            ItemName = "French Fries";
            Price = 2.99;
            ForGlutenFree = true;
            ForVegetarian = true;
            ForDiabetic = false;
            ForVegan = true;
        }
    }
}

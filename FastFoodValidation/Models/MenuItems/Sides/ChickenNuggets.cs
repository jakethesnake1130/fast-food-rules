using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Sides
{
    internal class ChickenNuggets : Side
    {
        public ChickenNuggets()
        {
            ItemName = "Chicken Nuggets";
            Price = 2.99;
            ForGlutenFree = false;
            ForVegetarian = false;
            ForDiabetic = false;
            ForVegan = false;
        }
    }
}

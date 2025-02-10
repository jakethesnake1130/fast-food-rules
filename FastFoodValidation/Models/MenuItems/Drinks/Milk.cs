using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Drinks
{
    internal class Milk : Drink
    {
        public Milk()
        {
            ItemName = "Milk";
            Price = 1.99;
            ForDiabetic = true;
            ForLactoseIntolerant = false;
            ForVegan = false;
        }
    }
}


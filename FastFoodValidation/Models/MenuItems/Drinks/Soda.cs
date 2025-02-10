using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Drinks
{
    internal class Soda : Drink
    {
        public Soda() 
        {
            ItemName = "Soda";
            Price = 2.99;
            ForDiabetic = false;
            ForLactoseIntolerant = true;
            ForVegan = true;
        }
    }
}

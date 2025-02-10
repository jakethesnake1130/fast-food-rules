using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Drinks
{
    internal class DietSoda : Drink
    {
        public DietSoda() 
        {
            ItemName = "Diet Soda";
            Price = 2.99;
            ForDiabetic = true;
            ForLactoseIntolerant = true;
            ForVegan = true;
        }
    }
}

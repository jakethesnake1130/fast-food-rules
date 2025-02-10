using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Drinks
{
    internal class Water : Drink
    {
        public Water() 
        {
            ItemName = "Water";
            Price = 1.99;
            ForDiabetic = true;
            ForLactoseIntolerant = true;
            ForVegan = true;
        }
    }
}

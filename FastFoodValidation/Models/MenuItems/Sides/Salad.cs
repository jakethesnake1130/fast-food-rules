using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Sides
{
    internal class Salad : Side
    {
        public Salad() 
        {
            ItemName = "Salad";
            Price = 2.99;
            ForGlutenFree = true;
            ForVegetarian = true;
            ForDiabetic = true;
            ForVegan = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class Hamburger : Entree
    {
        public Hamburger() 
        {
            ItemName = "Hamburger";
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

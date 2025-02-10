using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class VeggieBurger : Entree
    {
        public VeggieBurger()
        {
            ItemName = "Veggie Burger";
            Price = 12.99;
            ForGlutenFree = false;
            ForPorkFree = true;
            ForVegetarian = true;
            ForDiabetic = true;
            ForLactoseIntolerant = true;
            ForVegan = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class GlutenFreeCheeseburger : Entree
    {
        public GlutenFreeCheeseburger()
        {
            ItemName = "Gluten Free Cheeseburger";
            Price = 11.99;
            ForGlutenFree = true;
            ForPorkFree = true;
            ForVegetarian = false;
            ForDiabetic = true;
            ForLactoseIntolerant = false;
            ForVegan = false;
        }
    }
}

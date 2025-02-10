using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class BaconCheeseburger : Entree
    {
        public BaconCheeseburger()
        {
            ItemName = "Bacon Cheeseburger";
            Price = 12.99;
            ForGlutenFree = false;
            ForPorkFree = false;
            ForVegetarian = false;
            ForDiabetic = false;
            ForLactoseIntolerant = false;
            ForVegan = false;
        }
    }
}

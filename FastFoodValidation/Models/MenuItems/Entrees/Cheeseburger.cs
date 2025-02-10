using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class Cheeseburger : Entree
    {
        public Cheeseburger()
        {
            ItemName = "Cheeseburger";
            Price = 10.99;
            ForGlutenFree = false;
            ForPorkFree = true;
            ForVegetarian = false;
            ForDiabetic = true;
            ForLactoseIntolerant = false;
            ForVegan = false;
        }
    }
}

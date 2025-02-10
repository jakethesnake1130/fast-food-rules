using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Drinks
{
    internal class Drink
    {
        private readonly bool ForPorkFree = true;
        private readonly bool ForVegetarian = true;
        private readonly bool ForGlutenFree = true;

        public string ItemName;
        public double Price;
        public bool ForDiabetic;
        public bool ForLactoseIntolerant;
        public bool ForVegan;
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Sides
{
    internal class Side
    {
        private bool ForPorkFree = true;
        private bool ForLactoseIntolerant = true;

        public string ItemName;
        public double Price;
        public bool ForGlutenFree;
        public bool ForVegetarian;
        public bool ForDiabetic;
        public bool ForVegan;
    }
}

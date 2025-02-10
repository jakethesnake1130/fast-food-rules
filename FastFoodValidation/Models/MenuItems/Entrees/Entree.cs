using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models.MenuItems.Entrees
{
    internal class Entree
    {
        public string ItemName;
        public double Price;
        public bool ForGlutenFree;
        public bool ForPorkFree;
        public bool ForVegetarian;
        public bool ForDiabetic;
        public bool ForLactoseIntolerant;
        public bool ForVegan;
    }
}

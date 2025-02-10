using FastFoodValidation.Models.MenuItems.Drinks;
using FastFoodValidation.Models.MenuItems.Entrees;
using FastFoodValidation.Models.MenuItems.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Models
{
    internal class Combo
    {
        private readonly double Price = 14.99;
        public string ItemName { get; set; }
        public Entree Entree { get; set; }
        public Side Side { get; set; }
        public Drink Drink { get; set; }
        public bool ForGlutenFree;
        public bool ForPorkFree;
        public bool ForVegetarian;
        public bool ForDiabetic;
        public bool ForLactoseIntolerant;
        public bool ForVegan;

        public Combo(string itemName, Entree entree, Side side, Drink drink)
        {
            ItemName = itemName;
            Entree = entree;
            Side = side;
            Drink = drink;

            if (Entree.ForPorkFree)
                ForPorkFree = true;
            
            if (Entree.ForGlutenFree && side.ForGlutenFree)
                ForGlutenFree = true;
            
            if (Entree.ForVegetarian && side.ForVegetarian)
                ForVegetarian = true;

            if (Entree.ForLactoseIntolerant && drink.ForLactoseIntolerant)
                ForLactoseIntolerant = true;

            if (Entree.ForDiabetic && side.ForDiabetic && drink.ForDiabetic)
                ForDiabetic = true;
            
            if (Entree.ForVegan && side.ForVegan && drink.ForVegan)
                ForVegan = true;
        }
    }
}

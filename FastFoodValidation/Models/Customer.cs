using FastFoodValidation.Models.MenuItems.Drinks;
using FastFoodValidation.Models.MenuItems.Entrees;
using FastFoodValidation.Models.MenuItems.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FastFoodValidation.Models
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool IsLactoseIntolerant { get; set; }
        public bool IsDiabetic { get; set; }
        public bool IsPorkFree { get; set; }
        public bool IsGlutenFree { get; set; }
        public enum Restrictions
        {
            Vegetarian = 1,
            Vegan,
            [EnumMember(Value = "Lactose Intolerant")]
            LactoseIntolerant,
            Diabetic,
            [EnumMember(Value = "Pork Free")]
            PorkFree,
            [EnumMember(Value = "Gluten Free")]
            GlutenFree
        }

        public Customer()
        {
            CustomerId = 1;

            int[] selections = UserInterface.BuildProfile();

            if (selections.Contains(1))
                IsVegetarian = true;
            if (selections.Contains(2))
                IsVegan = true;
            if (selections.Contains(3))
                IsLactoseIntolerant = true;
            if (selections.Contains(4))
                IsDiabetic = true;
            if (selections.Contains(5))
                IsPorkFree = true;
            if (selections.Contains(6))
                IsGlutenFree = true;

            Console.WriteLine("\nYour profile has been built");
            if (selections.Length > 0)
            {
                List<string> dietaryRestrictions = GetRestrictionNames(selections);
                Console.WriteLine("\nYour dietary restrictions have been registered and include:");
                foreach (string dietaryRestriction in dietaryRestrictions)
                {
                    Console.WriteLine(dietaryRestriction);
                }
            }
            else
            {
                Console.WriteLine("\nYou have NO dietary restrictions! Nothing to worry about");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);
        }

        public void PrintCustomerOrders(List<Order> orderList)
        {
            UserInterface.PrintOrders(orderList, this);
        }

        public void PrintCustomerOrder(Order order)
        {
            UserInterface.PrintOrder(order, this);
        }

        public List<string> GetRestrictionNames(int[] selections)
        {
            List<string> restrictions = new List<String>();
            foreach (int selection in selections)
            {
                string restriction = Enum.GetName(typeof(Restrictions), selection);
                int index = Regex.Match(restriction, @"(?<=[a-z])([A-Z])").Index;

                if (index > 0)
                {
                    restriction = restriction.Insert(index, " ");
                }

                restrictions.Add(restriction);
            }

            return restrictions;
        }
    }
}

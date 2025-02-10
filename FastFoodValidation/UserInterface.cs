using FastFoodValidation.Models.MenuItems.Drinks;
using FastFoodValidation.Models.MenuItems.Entrees;
using FastFoodValidation.Models.MenuItems.Sides;
using FastFoodValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FastFoodValidation
{
    internal class UserInterface
    {
        public static void PrintOrders(List<Order> orderList, Customer customer)
        {
            foreach(Order order in orderList)
            {
                if(order.CustomerId != customer.CustomerId)
                    orderList.Remove(order);
            }

            List<string> orderStrings = new List<string>();

            if (orderList != null && orderList.Count > 0)
            {
                foreach (Order order in orderList)
                {
                    Console.WriteLine($"\n----Order #{orderList.IndexOf(order) + 1}----");

                    if (order.Combos.Count > 0)
                    {
                        order.Combos.ForEach(delegate (Combo combo)
                        {
                            Console.WriteLine(combo.ItemName + " ");
                        });
                    }

                    if (order.Entrees.Count > 0)
                    {
                        order.Entrees.ForEach(delegate (Entree entree)
                        {
                            Console.WriteLine(entree.ItemName);
                        });
                    }

                    if (order.Sides.Count > 0)
                    {
                        order.Sides.ForEach(delegate (Side side)
                        {
                            Console.WriteLine(side.ItemName);
                        });
                    }

                    if (order.Drinks.Count > 0)
                    {
                        order.Drinks.ForEach(delegate (Drink drink)
                        {
                            Console.WriteLine(drink.ItemName);
                        });
                    }
                }
            }          
        }

        public static void PrintOrder(Order order, Customer customer)
        {
            if (order.CustomerId != customer.CustomerId)
            {
                if (order.Combos.Count > 0)
                {
                    order.Combos.ForEach(delegate (Combo combo)
                    {
                        Console.WriteLine(combo.ItemName + " ");
                    });
                }

                if (order.Entrees.Count > 0)
                {
                    order.Entrees.ForEach(delegate (Entree entree)
                    {
                        Console.WriteLine(entree.ItemName);
                    });
                }

                if (order.Sides.Count > 0)
                {
                    order.Sides.ForEach(delegate (Side side)
                    {
                        Console.WriteLine(side.ItemName);
                    });
                }

                if (order.Drinks.Count > 0)
                {
                    order.Drinks.ForEach(delegate (Drink drink)
                    {
                        Console.WriteLine(drink.ItemName);
                    });
                }
            }
        }

        public static int[] ValidateAndBuildIntArray(string input)
        {
            int[] numbers = [];

            if (string.IsNullOrEmpty(input))
            {
                return numbers;
            }

            string pattern = "^[1-6](?:,[1-6])*$";

            if (!Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Invalid input: please enter only numbers seen on the menu, separated by commas");
                BuildProfile();
            }

            string[] splitInput = input.Split(',');
            HashSet<string> seen = new HashSet<string>();

            foreach (string num in splitInput)
            {
                if (seen.Contains(num))
                {
                    Console.WriteLine("Invalid input: please do not repeat numbers in your entry");
                    BuildProfile();
                }
                seen.Add(num);
            }

            numbers = Array.ConvertAll(splitInput, s => int.Parse(s));

            return numbers;
        }

        public static int[] BuildProfile()
        {
            Console.WriteLine("\nPlease use this guide to enter your dietary necessities:");
            Console.WriteLine("Enter the number corresponding to all that apply, separate your selections with commas");
            Console.WriteLine("For example, a diabetic, gluten-free vegetarian may enter 1,4,6");
            Console.WriteLine("\n1. Vegetarian");
            Console.WriteLine("2. Vegan");
            Console.WriteLine("3. Lactose Intolerant");
            Console.WriteLine("4. Diabetic");
            Console.WriteLine("5. Pork Free");
            Console.WriteLine("6. Gluten Free\n");
            string input = Console.ReadLine();


            Console.WriteLine("\nEvaluating your input...");
            int[] selections = ValidateAndBuildIntArray(input);

            return selections;
        }
    }
}

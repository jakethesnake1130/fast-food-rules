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
    internal class Order
    {
        public int CustomerId { get; set; }
        public double Price { get; set; }
        public List<Combo> Combos { get; set; }
        public List<Entree> Entrees { get; set; }
        public List<Side> Sides { get; set; }
        public List<Drink> Drinks { get; set; }
        public bool IsValid { get; set; }

        public Order()
        {
            Combos = new List<Combo>();
            Entrees = new List<Entree>();
            Sides = new List<Side>();
            Drinks = new List<Drink>();
            IsValid = true;
        }

        
        public static List<Order> BuildOrders()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Nanny Burger is compiling your orderList...");
            Console.WriteLine("This will be done automatically to save your precious time");

            List<Order> orderList = new List<Order>();
            
            Order order1 = new Order();

            Combo classicCombo = new Combo("Classic Combo", new Cheeseburger(), new FrenchFries(), new Soda());
            ChickenNuggets chickenNuggets = new ChickenNuggets();
            BaconCheeseburger baconCheeseburger = new BaconCheeseburger();
            order1.Combos.Add(classicCombo);
            order1.Sides.Add(chickenNuggets);
            order1.Entrees.Add(baconCheeseburger);
            
            
            Order order2 = new Order();

            Combo dietCombo = new Combo("Diet Combo", new GrilledChickenSandwich(), new Salad(), new DietSoda());
            order2.Combos.Add(dietCombo);


            Order order3 = new Order();

            Combo veganCombo = new Combo("Vegan Combo", new VeggieBurger(), new Salad(), new Soda());
            order3.Combos.Add(veganCombo);


            Order order4 = new Order();
            
            VeggieBurger veggieBurger = new VeggieBurger();
            Milk milk = new Milk();
            order4.Entrees.Add(veggieBurger);
            order4.Drinks.Add(milk);


            Order order5 = new Order();
            
            GlutenFreeCheeseburger glutenFreeCheeseburger = new GlutenFreeCheeseburger();
            FriedChickenSandwich friedChickenSandwich = new FriedChickenSandwich();
            order5.Entrees.Add(glutenFreeCheeseburger);
            order5.Entrees.Add(friedChickenSandwich);


            Order order6 = new Order();

            DietSoda dietSoda = new DietSoda();
            Hamburger hamburger = new Hamburger();
            Salad salad = new Salad();
            order6.Drinks.Add(dietSoda);
            order6.Entrees.Add(hamburger);

            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
            orderList.Add(order6);
            
            return orderList;
        }

        public static void AssignOrders(List<Order> orderList, int custId)
        {
            foreach (Order order in orderList)
            {
                order.CustomerId = custId;
            }
        }
    }
}

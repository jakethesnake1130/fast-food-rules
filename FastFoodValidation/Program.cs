using FastFoodValidation.Models;
using FastFoodValidation.Models.MenuItems.Drinks;
using FastFoodValidation.Models.MenuItems.Entrees;
using FastFoodValidation.Models.MenuItems.Sides;
using FastFoodValidation.Rules;
using NRules;
using NRules.Fluent;

namespace FastFoodValidation
{
    class Program()
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nanny Burger");
            Console.WriteLine("Where we protect you from yourself");

            Customer customer = new Customer();

            List<Order> orderList = Order.BuildOrders();
            Order.AssignOrders(orderList, customer.CustomerId);

            Console.WriteLine($"\t\tYou have {orderList.Count} orders pending evaluation");

            UserInterface.PrintOrders(orderList, customer);

            Console.WriteLine("\nYour orders are now ready to be evaluated...");
            Console.WriteLine("Press any key to proceed...");
            Console.ReadKey(true);

            RuleRepository ruleRepository = new RuleRepository();
            ruleRepository.Load(x => x.From(typeof(CancelTransactionRule).Assembly));


            var factory = ruleRepository.Compile();

            var session = factory.CreateSession();

            session.Insert(customer);
            foreach (var order in orderList)
            {
                session.Insert(order);
            }

            session.Fire();
        }
    }
}
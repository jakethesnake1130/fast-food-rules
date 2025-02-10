using FastFoodValidation.Models;
using NRules.Fluent.Dsl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Rules
{
    public class VegetarianRule : Rule
    {
        Customer customer = default!;
        IEnumerable<Order> orderList = default!;

        public override void Define()
        {
            When()
                .Match<Customer>(() => customer, customer => customer.IsVegetarian)
                .Query(() => orderList, x => x
                    .Match<Order>(
                        o => o.CustomerId == customer.CustomerId,
                        o => o.IsValid,
                        o => o.Entrees.Where(e => e.ForVegetarian == false).Any() ||
                             o.Sides.Where(s => s.ForVegetarian == false).Any() ||
                             o.Combos.Where(c => c.ForVegetarian == false).Any())
                    .Collect());
            Then()
                .Do(ctx => InvalidateOrders(orderList, customer))
                .Do(ctx => ctx.UpdateAll(orderList));
        }
        private static void InvalidateOrders(IEnumerable<Order> orderList, Customer customer)
        {
            foreach (Order order in orderList)
            {
                order.IsValid = false;
                Console.WriteLine("An order was found to be invalid on the basis of your vegetarianism");
                customer.PrintCustomerOrder(order);
            }
        }
    }
}

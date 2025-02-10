using FastFoodValidation.Models;
using NRules.Fluent.Dsl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Rules
{
    [Priority(-1)]
    public class FinalizeOrderRule : Rule
    {
        Customer customer = default!;
        IEnumerable<Order> orderList = default!;

        public override void Define()
        {
            When()
                .Match<Customer>(() => customer)
                .Query(() => orderList, x => x
                    .Match<Order>(
                        o => o.IsValid,
                        o => o.CustomerId == customer.CustomerId)
                .Collect());
            Then()
                .Do(ctx => FinalizeOrder(customer, orderList));
        }

        private static void FinalizeOrder(Customer customer, IEnumerable<Order> orderList)
        {
            Console.WriteLine("\nAll of your orders have been successfully evaluated against your dietary restrictions");
            Console.WriteLine("The following orders are absolutely safe and healthy for you to eat:");
            customer.PrintCustomerOrders(orderList.ToList());
        }
    }
}

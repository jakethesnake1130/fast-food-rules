using FastFoodValidation.Models;
using NRules.Fluent.Dsl;
using NRules.RuleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodValidation.Rules
{
    public class CancelTransactionRule : Rule
    {
        public override void Define()
        {
            When()
                .Not<Order>(o => o.IsValid);
            Then()
                .Do(ctx => CancelTransaction())
                .Action(ctx => ctx.Halt(), ActionTrigger.Activated);
        }

        public static void CancelTransaction() 
        {
            Console.WriteLine("\nUnfortunately, we cannot allow you to eat anything you have ordered");
            Console.WriteLine("A $5.00 health and safety fee has been deducted from your account");
        }
    }
}

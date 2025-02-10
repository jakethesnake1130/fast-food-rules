--- Models ---
Straightforward Objects for the most part. I inherited from Parent classes (Entree, Side, Drink) for the Menu Items in order to make building combos a bit easier.
Constructors for food objects are simple, with the minor exception of Combo which evaluates its members as a basis for Property assignment.

Customer Class has a pretty involved constructor that calls UserInterface and begins the BuildProfile process. The resulting Customer
object has Properties assigned which will be important later on. Depends on UserInterface in significant ways.

Order Class has lists of Menu Items and Combos which will be compared against the aforementioned Customer Properties
I populated a bunch of Orders by hardcode because I thought the prompting would have been too onerous through the CLI.

--- UserInterface ---
Responsible for prompting the user, receiving inputs, and validating inputs during the Customer builder process.
Also handle the logic for printing out Orders to the console. Those methods are called from the Customer class to allow cleaner code within the Rules
without blowing up the Customer Class with a lot of Console.WriteLine.

--- Rules ---
There are eight Rules. Six for each of the possible Customer dietary restrictions and accompanying Menu Item/Combo Properties, and two for finalizing.
The six dietary Rules work mostly the same. First, they check whether the Customer has its dietary restriction.
Then, the Rule checks Order Facts for identity with Customer on CustomerId. The Rule also checks that the IsValid property is true.
(i.e. checks that an Order belongs to the Customer and has not been disqualified by another rule).
Dietary Rules also check whether any of the elements of an Order has a true bool Property which corresponds to that Rule's dietary restriction.
If all of the above conditions are met, the Rule fires. 
Any Order with an element which has a Property corresponding to the Customer's dietary restriction set to true is added to the orderList alias, and later has its 
IsValid Property toggled to false. The customer is notified, and the invalid Order is printed to be reviewed by the user.

The other two Rules (FinalizeOrderRule and CancelOrderRule) deal with completing the cycle.
FinalizeOrderRule has its priority set to -1 so that it will run only after all other eligible rules have fired and removed
any invalid Orders. When its turn comes up, it collects all valid orders and prints them to be viewed. The process then ends.

CancelOrder is eligible to fire when all Order Facts have been evaluated as invalid. In this case, the Customer is notified and
an ActionTrigger is used to prevent FinalizeOrder from firing (as it was eligible previously and the cycle was queued to fire).
In other words, if CancelOrder is Activated, the ActionTrigger will ensure that it is the last Rule to fire by halting the execution process.


--- Program ---
Mostly keeps things moving along. This is where the Rules Engine is compiled and fired.

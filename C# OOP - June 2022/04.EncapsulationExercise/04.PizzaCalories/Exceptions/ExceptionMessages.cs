using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories.Exceptions
{
    public class ExceptionMessages
    {
        public static string DoughTypeException = "Invalid type of dough.";

        public static string DoughWeightException = "Dough weight should be in the range [1..200].";

        public static string ToppingTypeException = "Cannot place {0} on top of your pizza.";

        public static string ToppingWeightException = "{0} weight should be in the range [1..50].";

        public static string NumberOfToppingsException = "Number of toppings should be in range [0..10].";

        public static string PizzaNameException = "Pizza name should be between 1 and 15 symbols.";

    }
}

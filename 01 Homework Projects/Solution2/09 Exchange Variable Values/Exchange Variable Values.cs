/*  Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.  */

using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            int firstVariable = 5;
            int secondVariable = 10;
            int temporalVariable = firstVariable;
            Console.WriteLine("before exchage: {0} and {1}", firstVariable, secondVariable);
            firstVariable = secondVariable;
            secondVariable = temporalVariable;
            Console.WriteLine("after exchage: {0} and {1}", firstVariable, secondVariable);
        }
    }


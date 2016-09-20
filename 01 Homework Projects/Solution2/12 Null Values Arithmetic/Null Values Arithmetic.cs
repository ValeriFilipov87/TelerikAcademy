/*  Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? firstVariable = null;
            double? secondVariable = null;
            Console.WriteLine("Int: {0}, Double: {1}", firstVariable, secondVariable);
            firstVariable = firstVariable + null;
            secondVariable = secondVariable + 20;
            Console.WriteLine("Int: {0}, Double: {1}", firstVariable, secondVariable);
        }
    }


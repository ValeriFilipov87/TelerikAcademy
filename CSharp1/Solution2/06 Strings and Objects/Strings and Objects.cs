﻿/*  Declare two string variables and assign them with Hello and World.
    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting). */

using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstVariable = "Hello";
        string secondVariable = "World";
        object objectVariable = firstVariable + " " + secondVariable;
        string thirdVariable = (string)objectVariable;
        Console.WriteLine("The object is {0}\nThe third variable is {1}",objectVariable,thirdVariable);
    }
}


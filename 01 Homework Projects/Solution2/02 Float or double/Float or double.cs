/* Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? */

using System;

    class FloatOrDouble
    {
        static void Main()
        {
        double firstNumber = 34.567839023;
        float secondNumber = 12.345F;
        double thirdNumber = 8923.1234857;
        float forthNumber = 3456.091F;

        Console.WriteLine("The First number {0} is double \nThe Second number {1} is float \nThe Third number {2} is double \nThe Forth number {3} is float",firstNumber,secondNumber,thirdNumber,forthNumber);
        }
    }

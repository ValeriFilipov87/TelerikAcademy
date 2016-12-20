/*  Problem 12.* Zero Subset

We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.

Hint: you may check for zero each of the 31 subsets with 31 if statements. */


using System;

class ZeroSubset
{
    public static double a = new double();
    public static double b = new double();
    public static double c = new double();
    public static double d = new double();
    public static double e = new double();
    public static bool checkfive = true;
    public static bool checkfour = true;
    public static bool checkthree = true;
    public static bool checktwo = true;
    public static bool checkone = true;

    static void Main()
    {
        InputFromUser();
        CheckForFiveDigits();
        CheckForFourDigits();
        CheckThreeDigits();
        CheckTwoDigits();
        CheckOneDidit();

        if (checkfive && checkfour && checkthree && checktwo)
        {
            InvalidReturn();
        }

    }

    private static void CheckOneDidit()
    {
        if (a == 0 || b == 0 || c == 0 || d == 0 || e == 0)
        {
            Console.WriteLine("0");
            checkone = false;
        }
    }

    private static void CheckTwoDigits()
    {
        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            checktwo = false;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, c, a + c);
            checktwo = false;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, d, a + d);
            checktwo = false;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", a, e, a + e);
            checktwo = false;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", b, c, b + c);
            checktwo = false;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", b, d, b + d);
            checktwo = false;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", b, e, b + e);
            checktwo = false;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", c, d, c + d);
            checktwo = false;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", c, e, c + e);
            checktwo = false;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = {2}", d, e, d + e);
            checktwo = false;
        }
    }

    private static void CheckThreeDigits()
    {
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
            checkthree = false;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, d, a + b + d);
            checkthree = false;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, e, a + b + e);
            checkthree = false;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, c, d, a + c + d);
            checkthree = false;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, c, e, a + c + e);
            checkthree = false;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", a, d, e, a + d + e);
            checkthree = false;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", b, c, d, b + c + d);
            checkthree = false;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", b, c, e, b + c + e);
            checkthree = false;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", b, d, e, b + d + e);
            checkthree = false;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", c, d, e, c + d + e);
            checkthree = false;
        }
    }

    private static void CheckForFourDigits()
    {
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, d, a + b + c + d);
            checkfour = false;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", b, c, d, e, b + c + d + e);
            checkfour = false;
        }
        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, c, d, e, a + c + d + e);
            checkfour = false;
        }
        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, d, e, a + b + d + e);
            checkfour = false;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", a, b, c, e, a + b + c + e);
            checkfour = false;
        }
    }

    private static void CheckForFiveDigits()
    {
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", a, b, c, d, e, a + b + c + d + e);
            checkfive = false;
        }
    }

    private static void InvalidReturn()
    {
        Console.WriteLine("no zero subset");
    }

    private static void InputFromUser()
    {
        Console.WriteLine("Please input your first digit: ");
        a = InputDigit();
        Console.WriteLine("Please input your second digit: ");
        b = InputDigit();
        Console.WriteLine("Please input your third digit: ");
        c = InputDigit();
        Console.WriteLine("Please input your fourth digit: ");
        d = InputDigit();
        Console.WriteLine("Please input your fifth digit: ");
        e = InputDigit();
        Console.Clear();
        Console.WriteLine("{0}  {1}  {2}  {3}  {4}", a, b, c, d, e);
    }

    private static double InputDigit()
    {
        double userInput = new double();
        bool check;
        check = double.TryParse(Console.ReadLine(), out userInput);

        while (!check)
        {
            Console.WriteLine("Wrong input! Please input a digit");
            check = double.TryParse(Console.ReadLine(), out userInput);
        }
        return userInput;
    }
}


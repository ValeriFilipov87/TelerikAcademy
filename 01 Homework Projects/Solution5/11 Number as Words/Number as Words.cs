/*  Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

*/

using System;
using System.Threading;

class NumberAsWords
{
    public static string[] oneDigit = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    public static string[] teenDigits = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    public static string[] twoDigits = new string[] { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    public static string threeDigits = "hundred";
    public static string conjuction = "and";
    public static int hundreds = new int();
    public static int tens = new int();
    public static int ones = new int();
    static void Main()
    {

        while (true)
        {
                       
            Console.WriteLine("Please input intiger digit from [0...999]");
            int digit = IntigerUserInput();
            Console.Clear();
            Console.WriteLine(digit);
            hundreds = digit / 100;
            tens = (digit - hundreds * 100) / 10;
            ones = (digit - hundreds * 100 - tens * 10) / 1;

            if (hundreds != 0 && tens > 1 && ones > 0)
            {
                oneDigit[hundreds] = UppercaseFirst(oneDigit[hundreds]);
                Console.WriteLine("{0} {1} {2} {3} {4}", oneDigit[hundreds], threeDigits, conjuction, twoDigits[tens - 1], LowercaseFirst(oneDigit[ones]));
                oneDigit[hundreds] = LowercaseFirst(oneDigit[hundreds]);
            }
            if (hundreds == 0 && tens > 1 && ones > 0)
            {
                twoDigits[tens - 1] = UppercaseFirst(twoDigits[tens - 1]);
                Console.WriteLine("{0} {1}", twoDigits[tens - 1], oneDigit[ones]);
                twoDigits[tens - 1] = LowercaseFirst(twoDigits[tens - 1]);
            }
            if (hundreds == 0 && tens == 0)
            {
                oneDigit[ones] = UppercaseFirst(oneDigit[ones]);
                Console.WriteLine("{0}", oneDigit[ones]);
                oneDigit[ones] = LowercaseFirst(oneDigit[ones]);
            }
            if (hundreds == 0 && tens == 1)
            {
                teenDigits[ones] = UppercaseFirst(teenDigits[ones]);
                Console.WriteLine("{0}", teenDigits[ones]);
                teenDigits[ones] = LowercaseFirst(teenDigits[ones]);
            }
            if (hundreds != 0 && tens == 0 && ones == 0)
            {
                oneDigit[hundreds] = UppercaseFirst(oneDigit[hundreds]);
                Console.WriteLine("{0} {1}", oneDigit[hundreds], threeDigits);
                oneDigit[hundreds] = LowercaseFirst(oneDigit[hundreds]);
            }
            if (hundreds != 0 && tens != 0 && ones == 0)
            {
                oneDigit[hundreds] = UppercaseFirst(oneDigit[hundreds]);
                Console.WriteLine("{0} {1} {2} {3}", oneDigit[hundreds], threeDigits, conjuction, twoDigits[tens - 1]);
                oneDigit[hundreds] = LowercaseFirst(oneDigit[hundreds]);
            }
            if (hundreds != 0 && tens == 0 && ones != 0)
            {
                oneDigit[hundreds] = UppercaseFirst(oneDigit[hundreds]);
                Console.WriteLine("{0} {1} {2} {3}", oneDigit[hundreds], threeDigits, conjuction, LowercaseFirst(oneDigit[ones]));
                oneDigit[hundreds] = LowercaseFirst(oneDigit[hundreds]);
            }
            if (hundreds != 0 && tens == 1 & ones != 0)
            {
                oneDigit[hundreds] = UppercaseFirst(oneDigit[hundreds]);
                Console.WriteLine("{0} {1} {2} {3}", oneDigit[hundreds], threeDigits, conjuction, teenDigits[ones]);
                oneDigit[hundreds] = LowercaseFirst(oneDigit[hundreds]);
            }
            if (hundreds == 0 && tens>1 && ones ==0)
            {
                twoDigits[tens - 1] = UppercaseFirst(twoDigits[tens - 1]);
                Console.WriteLine("{0}", twoDigits[tens - 1]);
                twoDigits[tens - 1] = LowercaseFirst(twoDigits[tens - 1]);
            }
            
        }
    }

    private static int IntigerUserInput()
    {
        int userInput = new int();
        bool check;
        check = int.TryParse(Console.ReadLine(), out userInput);
        if (userInput < 0 || userInput > 999)
        {
            check = false;
        }
        while (!check)
        {
            Console.WriteLine("Wrong input! Please input intiger digit from [0...999]");
            check = int.TryParse(Console.ReadLine(), out userInput);
            if (userInput < 0 || userInput > 999)
            {
                check = false;
            }
        }
        return userInput;
    }
    private static string UppercaseFirst(string s)
    {
        // Check for empty string.
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        // Return char and concat substring.
        return char.ToUpper(s[0]) + s.Substring(1);
    }
    private static string LowercaseFirst(string s)
    {
        // Check for empty string.
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        // Return char and concat substring..
        return char.ToLower(s[0]) + s.Substring(1);
    }
}


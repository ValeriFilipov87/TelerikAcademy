/*  Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

*/

using System;

class NumberAsWords
{
    public static string[] oneDgit = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    public static string[] teenDgits = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    public static string[] twoDgits = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    public static string threeDigits = "hundred";
    public static string conjuction = "and";
    public static int hundreds = new int();
    public static int tens = new int();
    public static int ones = new int();
    static void Main()
    {


        Console.WriteLine("Please input intiger digit from [0...999]");
        int digit = IntigerUserInput();
        
        hundreds = digit / 100;
        tens = (digit - hundreds*100) / 10;
        ones = (digit - hundreds * 100 - tens*10) / 1;
        Console.WriteLine("{0} {1} {2}", hundreds,tens,ones);

        if (digit > 0)
        {


        }
        
        
       
        
        //TO DO: Find digit in databases
        //TO DO: Print result
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
}


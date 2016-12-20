/* Problem 11. Random Numbers in Given Range

Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

*/

using System;

class RandomNumbersInGivenRange
{
    public static int n = new int();
    public static int min = new int();
    public static int max = new int();
    public static Random rnd = new Random();
    public static int result = new int();

    static void Main()
    {
        UserInterface();
        
        for (int i = 0; i < n; i++)
        {
            result = rnd.Next(min,max+1);
            Console.Write(result + " ");
        }
    }

    private static void UserInterface()
    {
        Console.Write("Insert n: ");
        n = UserInput();
        Console.Write("Insert min: ");
        min = UserInput();
        Console.Write("Insert max: ");
        max = UserInput();

        while (min >= max)
        {
            Console.WriteLine("min must be less than max!\nInsert max: ");
            max = UserInput();
        }
    }

    private static int UserInput()
    {
        int input = new int();
        bool check = int.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            Console.WriteLine("The input is wrong!");
            check = int.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}


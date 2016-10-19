/*  Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.

*/

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        PrintMenu();
        int choice = IntUserInput();
        bool check = true;
        while (check)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please input an integer number: ");
                    int intInput = IntUserInput();
                    intInput++;
                    Console.WriteLine("Result is {0}", intInput);
                    check = false;
                    break;
                case 2:
                    Console.WriteLine("Please input a double number: ");
                    double doubleInput = DoubleUserInput();
                    doubleInput++;
                    Console.WriteLine("Result is {0}", doubleInput);
                    check = false;
                    break;
                case 3:
                    Console.WriteLine("Please input a string: ");
                    string stringInput = Console.ReadLine();
                    Console.WriteLine(stringInput+"*");
                    check = false;
                    break;
                default: Console.WriteLine("Invalid choice! Please, try again:"); choice = IntUserInput(); break;
            }

        }
    }

    private static void PrintMenu()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.WriteLine("Input your choice: ");
    }

    private static int IntUserInput()
    {
        int input = new int();
        bool check;
        check = int.TryParse(Console.ReadLine(), out input);

        while (!check)
        {
            Console.WriteLine("Wrong input! Please input an intiger digit");
            check = int.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }

    private static double DoubleUserInput()
    {
        double input = new double();
        bool check;
        check = double.TryParse(Console.ReadLine(), out input);

        while (!check)
        {
            Console.WriteLine("Wrong input! Please input an double digit");
            check = double.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}


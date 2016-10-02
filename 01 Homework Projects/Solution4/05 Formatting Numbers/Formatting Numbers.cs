/*  Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned. */


using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please insert an intiger between 0 and 500:");
        int firstNumber;
        bool isParsed = int.TryParse(Console.ReadLine(), out firstNumber);

        while (isParsed = !true || firstNumber <= 0 || firstNumber > 500)
        {
            Console.Clear();
            Console.WriteLine("Wrong input!");
            Console.WriteLine("Please insert integer between 0 and 500:");
            isParsed = int.TryParse(Console.ReadLine(), out firstNumber);
        }
        Console.WriteLine("Please insert two float digits:");
        float secondNumber = float.Parse(Console.ReadLine());
        float thirdNumber = float.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));

        Console.WriteLine("{0,-10:X} |{1}| {2,10:F2} |{3,-10:F3}|", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);
    }
}


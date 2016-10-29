/*  Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;

class OddAndEvenProduct
{
    public static int lengthSequence = LengthSequence();
    public static int[] sequence = SequenceInput(lengthSequence);
    static void Main()
    {
        Calculate(sequence);
    }

    private static void Calculate(int[] sequence)
    {
        int resultEvens = 1;
        int resultOdds = 1;
        int check = new int();

        for (int i = 1; i <= lengthSequence; i++)
        {
            check = i % 2;
            if (check == 0)
            {
                resultEvens *= sequence[i - 1];
            }
            else
            {
                resultOdds *= sequence[i - 1];
            }
        }
        if (resultEvens == resultOdds)
        {
            Console.WriteLine("YES! The product is: {0}", resultEvens);
        }
        else
        {
            Console.WriteLine("NO!\nOdd Product is: {0}\nEven Product is {1}", resultOdds, resultEvens);

        }
    }

    private static int[] SequenceInput(int lengthSequence)
    {
        int length = lengthSequence;
        int[] sequence = new int[length];
        for (int i = 0; i < length; i++)
        {
            sequence[i] = UserInput();
        }
        return sequence;
    }

    private static int LengthSequence()
    {
        Console.Write("Please input length of the sequence: ");
        int length = UserInput();
        while (length <= 0)
        {
            Console.Write("Invalid choice! Please input positive number for the length: ");
            length = UserInput();
        }
        Console.WriteLine("Length of the sequence is: {0}", length);
        Console.WriteLine("Please input {0} digits", length);
        return length;
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


/*  Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;

class OddAndEvenProduct
{
    public static int lengthSequence = int.Parse(Console.ReadLine());
    public static int[] sequence = SequenceInput(lengthSequence);
    static void Main()
    {
        Calculate(sequence);
    } 

    private static void Calculate(int[] sequence)
    {
        long resultEvens = 1;
        long resultOdds = 1;
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
            Console.WriteLine("yes {0}", resultEvens);
        }
        else
        {
            Console.WriteLine("no {0} {1}", resultOdds, resultEvens);

        }
    }

    private static int[] SequenceInput(int lengthSequence)
    {
        int length = lengthSequence;
        string input = Console.ReadLine();
        int[] sequence = new int[lengthSequence];
        string[] digits = input.Split(' ');
        for (int i = 0; i < lengthSequence; i++)
        {
            sequence[i] = int.Parse(digits[i]);
        }
        return sequence;
    }
}


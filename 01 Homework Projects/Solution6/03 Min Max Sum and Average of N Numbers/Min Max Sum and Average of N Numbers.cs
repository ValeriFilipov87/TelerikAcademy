/*  Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
*/

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {

        int lengthSequence = int.Parse(Console.ReadLine());

        double[] sequence = new double[lengthSequence];
        double max = double.MinValue;
        double min = double.MaxValue;
        double sum = new double();
        double avg = new double();

        for (int i = 0; i < lengthSequence; i++)
        {
            sequence[i] = double.Parse(Console.ReadLine());

            if (sequence[i] > max)
            {
                max = sequence[i];
            }
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
            sum = sum + sequence[i];
            avg = sum / lengthSequence;
        }
        Console.WriteLine("min={0:0.00}", min);
        Console.WriteLine("max={0:0.00}", max);
        Console.WriteLine("sum={0:0.00}", sum);
        Console.WriteLine("avg={0:0.00}", avg);
    }
}



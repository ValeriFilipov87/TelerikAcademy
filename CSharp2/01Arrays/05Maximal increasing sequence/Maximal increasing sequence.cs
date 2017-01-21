/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

input	                result
3, 2, 3, 4, 2, 2, 4	    2, 3, 4
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Maximal_increasing_sequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] digits = input.Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            int currentSequence = 1;
            int longestSequence = 1;
            int lastIndex = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (i < digits.Length - 1)
                {
                    if (digits[i] < digits[i + 1])
                    {
                        if (digits[i + 1] - digits[i] == 1)
                        {
                            currentSequence++;
                        }
                    }
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        lastIndex = i + 1;
                    }
                    if (digits[i] > digits[i + 1])
                    {
                        currentSequence = 1;
                    }
                }
            }
            for (int i = lastIndex - longestSequence + 1; i <= lastIndex; i++)
            {
                if (i != lastIndex)
                {
                    Console.Write(digits[i] + ",");
                }
                else
                {
                    Console.Write(digits[i]);
                }
            }
            Console.WriteLine();
        }
    }
}

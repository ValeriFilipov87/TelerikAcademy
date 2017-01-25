/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] digits = input.Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            int maxDigits = digits.Max();
            int[] otherPositiveDigits = new int[maxDigits + 1];
            int[] otherNegativeDigits = new int[maxDigits + 1];

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] >= 0)
                {
                    otherPositiveDigits[digits[i]]++;
                }
                else
                {
                    int index = -1 * digits[i];
                    otherNegativeDigits[index]++;
                }
            }
            int maxOtherDigit = otherPositiveDigits.Max();
            int frequentDigit = Array.IndexOf(otherPositiveDigits, maxOtherDigit);

            int maxNegativeDigit = otherNegativeDigits.Max();
            int frequentNegativeDigit = Array.IndexOf(otherNegativeDigits, maxNegativeDigit);
            frequentNegativeDigit *= -1;
            if (maxOtherDigit>=maxNegativeDigit)
            {
                Console.WriteLine(frequentDigit);
            }
            else
            {
                Console.WriteLine(frequentNegativeDigit);
            }

            
        }
    }
}

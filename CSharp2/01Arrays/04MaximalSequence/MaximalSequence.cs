using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] digits = input.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            int currentSequnce = 1;
            int longestSequnce = 1;
            int lastIndex = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                if (i < digits.Length - 1)
                {
                    if (digits[i] == digits[i + 1])
                    {
                        currentSequnce++;                        
                    }
                    if (currentSequnce > longestSequnce)
                    {
                        longestSequnce = currentSequnce;
                        lastIndex = i + 1;
                    }
                    if (digits[i] != digits[i + 1])
                    {
                        currentSequnce = 1;
                    }
                }
            }
            for (int i = lastIndex - longestSequnce + 1; i <= lastIndex; i++)
            {
                if (i!=lastIndex)
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

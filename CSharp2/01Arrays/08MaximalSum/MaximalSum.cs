using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] digits = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Clear();
                digits[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = 0;
            int maxSum = 0;
            int sequenceStart = 0;
            int sequenceStop = 0;
            int tempPosition = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > digits[i] + currentSum)
                {
                    currentSum = digits[i];
                    tempPosition = i;
                }
                else
                {
                    currentSum += digits[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    sequenceStart = tempPosition;
                    sequenceStop = i;
                }
            }
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
                Console.Write(',');
            }
            Console.WriteLine();
            for (int i = sequenceStart; i <= sequenceStop; i++)
            {
                Console.Write(digits[i]);
                Console.Write(',');
            }
            Console.WriteLine();
            Console.WriteLine(maxSum);
        }
    }
}

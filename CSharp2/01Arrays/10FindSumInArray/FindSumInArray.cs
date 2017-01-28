using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] digitsArray = input.Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            int currentSum = 0;
            int start = 0;
            int stop = 0;
            int restart = 0;

            for (int i = 0; i < digitsArray.Length; i++)
            {
                
                if (currentSum != sum)
                {
                    currentSum += digitsArray[i];
                }
                if (currentSum > sum)
                {
                    restart++;
                    currentSum = digitsArray[restart];
                    i = restart;
                    start = restart;
                }
                if (currentSum == sum)
                {
                    stop = i;
                    break;
                }
            }
            Console.WriteLine(currentSum);
            for (int i = start; i <= stop; i++)
            {
                Console.Write(digitsArray[i]);
                if (i!=stop)
                {
                    Console.Write(',');
                }
                
            }
            Console.WriteLine();
        }
    }
}

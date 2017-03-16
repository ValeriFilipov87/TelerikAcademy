using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Integer_Calculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            int[] userInput = UserInput();
            int result = new int();
            double average = new double();
            result = MinimumOfSequence(userInput);
            PrintResult(result);
            result = MaximumOfSequence(userInput);
            PrintResult(result);
            average = AverageOfSequence(userInput);
            PrintDoubleResult(average);
            result = SumOfSequence(userInput);
            PrintResult(result);
            long res = new long();
            res = ProductOfSequence(userInput);
            
            Console.WriteLine(res);
        }

        private static void PrintDoubleResult(double average)
        {
            Console.WriteLine("{0:F2}", average);
        }

        private static long ProductOfSequence(int[] userInput)
        {
            long result = 1L;
            for (int i = 0; i < userInput.Length; i++)
            {
                result *= userInput[i];
            }
            return result;
        }

        private static int SumOfSequence(int[] userInput)
        {
            return userInput.Sum();
        }

        private static double AverageOfSequence(int[] userInput)
        {
            return userInput.Average();
        }

        private static int MaximumOfSequence(int[] userInput)
        {
            return userInput.Max();
        }

        private static int MinimumOfSequence(int[] userInput)
        {
            return userInput.Min();
        }

        private static void PrintResult(int result)
        {
            //if (result % 1 == 0)
            //{
                Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("{0:F2}", result);
            //}
        }

        private static int[] UserInput()
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            return input;
        }
    }
}

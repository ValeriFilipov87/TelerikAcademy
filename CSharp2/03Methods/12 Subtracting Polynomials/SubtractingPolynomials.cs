using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Subtracting_Polynomials
{
    class SubtractingPolynomials
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] firstP = ReadInput();
            long[] secondP = ReadInput();
            long[] resultAdding = AddingP(firstP, secondP, N);
            long[] resultSubstract = SubstractP(firstP, secondP, N);
            long[] resultMultiplying = MultiplyingP(firstP, secondP, N);
            Console.WriteLine("Adding Polinomials:");
            PrintResult(resultAdding);
            Console.WriteLine("Substract Polinomials:");
            PrintResult(resultSubstract);
            Console.WriteLine("Multiply Polinomials:");
            PrintResult(resultMultiplying);
        }

        private static long[] MultiplyingP(long[] arrayOne, long[] arrayTwo, int length)
        {
            long[] result = new long[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = arrayOne[i] * arrayTwo[i];
            }
            return result;
        }

        private static long[] SubstractP(long[] arrayOne, long[] arrayTwo, int length)
        {
            long[] result = new long[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = arrayOne[i] - arrayTwo[i];
            }
            return result;
        }

        private static void PrintResult(long[] result)
        {
            string print = string.Join(" ", result);
            Console.WriteLine(print);
        }

        private static long[] AddingP(long[] arrayOne, long[] arrayTwo, int length)
        {
            long[] result = new long[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = arrayOne[i] + arrayTwo[i];
            }
            return result;
        }

        private static long[] ReadInput()
        {
            long[] input = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            return input;
        }
    }
}

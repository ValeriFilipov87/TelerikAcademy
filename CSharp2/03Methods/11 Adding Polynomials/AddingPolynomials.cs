using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Adding_Polynomials
{
    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] firstP = ReadInput();
            long[] secondP = ReadInput();
            long[] result = AddingP(firstP,secondP,N);
            PrintResult(result);           
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

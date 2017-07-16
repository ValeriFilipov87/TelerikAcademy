using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Sum_integers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {            
            int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            int result = input.Sum();

            Console.WriteLine(result);
        }
    }
}

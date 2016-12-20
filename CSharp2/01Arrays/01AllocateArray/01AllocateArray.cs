using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AllocateArray
{
    class 01AllocateArray
    {
        static void Main(string[] args)
        {
            int[] digits = new int[20];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = i * 5;
                Console.Write(digits[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

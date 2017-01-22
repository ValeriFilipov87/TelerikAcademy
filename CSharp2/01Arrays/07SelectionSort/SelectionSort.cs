using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] digits = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            for (int i = 0; i < digits.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < digits.Length; j++)
                {
                    if (digits[j] < digits[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = 0;
                    temp = digits[i];
                    digits[i] = digits[min];
                    digits[min] = temp;               
                }
            }
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}

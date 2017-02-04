using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            bool[] array = new bool[N];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(N); i++)
            {
                if (array[i] == true)
                {
                    for (int j = i * i; j < N; j = j + i)
                    {
                        array[j] = false;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    Console.Write(i);
                    if (i < array.Length - 1)
                    {
                        Console.Write(',');
                    }
                }                
            }
            Console.WriteLine();
        }
    }
}

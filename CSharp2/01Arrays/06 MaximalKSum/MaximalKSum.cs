/* Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] sequence = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Clear();
                sequence[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (sequence[i] <= sequence[j])
                    {
                        int one = sequence[i];
                        int two = sequence[j];
                        sequence[i] = two;
                        sequence[j] = one;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            for (int i = 0; i < K; i++)
            {
                sum += sequence[i];
            }
            Console.WriteLine(sum);
            for (int i = 0; i < N; i++)
            {
                Console.Write(sequence[i]);
                Console.Write(',');
            }
            Console.WriteLine();
        }
    }
}

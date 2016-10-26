/* Special for bace Kiko */

using System;


namespace ConsoleApplication1
{
    class Program
    {
        public static int acc = 1;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long result = factorial(n,acc);
            Console.WriteLine(result);
        }

        private static long factorial(int n, int acc)
        {

            /*if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }*/
            if (n == 0)
            {
                return acc;
            }
            else
            {
                return factorial(n - 1, acc * n);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Random_numbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random rndGenerator = new Random();
            for (int i = 0; i < 10; i++)
            {
                int digit = rndGenerator.Next(100,201);
                Console.WriteLine(digit);
            }
        }
    }
}

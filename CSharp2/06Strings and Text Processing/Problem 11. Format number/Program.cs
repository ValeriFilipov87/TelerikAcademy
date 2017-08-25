using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Format_number
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            Console.WriteLine("{0}",input);
            Console.WriteLine("{0:X}", input);
            Console.WriteLine("{0:P2}", input);
            Console.WriteLine("{0:E2}", input);
        }
    }
}

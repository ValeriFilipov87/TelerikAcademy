using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.String_length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;

            if (length < 20)
            {
                input = input.PadRight(20, '*');
            }
            Console.WriteLine(input);
        }
    }
}

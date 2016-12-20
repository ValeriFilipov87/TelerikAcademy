using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int result = a % 26;
            Console.WriteLine(result);
            Console.WriteLine((char)('A'+(result+0)%26));
              
        }
    }
}

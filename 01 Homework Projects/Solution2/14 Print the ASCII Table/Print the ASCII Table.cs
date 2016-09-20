using System;
using System.Text;

    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.ASCII;
            for(int i = 31; i<128; i++)
            {
                char x = (char)i;
                Console.WriteLine(x);
            }
        }
    }


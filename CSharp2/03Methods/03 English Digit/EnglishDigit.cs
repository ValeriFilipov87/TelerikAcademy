using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_English_Digit
{
    class EnglishDigit
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PringLastDigit(input);
        }

        private static void PringLastDigit(int input)
        {
            int lastDigit = input % 10;
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(digits[lastDigit]);
        }
    }
}

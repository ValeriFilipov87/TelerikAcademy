using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           // double digit = ConvertToDigit(input);
            //double result = Math.Sqrt(digit);
            try
            {
                double digit = ConvertToDigit(input);
                double result = Math.Sqrt(digit);
                Console.WriteLine("{0:F3}", result);
            }            
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            
           // Console.WriteLine(result);
        }

        private static double ConvertToDigit(string input)
        {
            double result = new int();
            try
            {
                double digit = double.Parse(input);
                result = digit;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid number");
            }

            if (result <0)
            {
                throw new ArgumentException("Invalid number");
            }
            return result;
        }
    }
}

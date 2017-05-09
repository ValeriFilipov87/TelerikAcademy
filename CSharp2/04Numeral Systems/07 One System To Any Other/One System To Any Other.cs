using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07_One_System_To_Any_Other
{
    class Program
    {
        public static int s = new int();
        public static string N = "";
        public static int d = new int();
        public static char[] map = { 'A', 'B', 'C', 'D', 'E', 'F' };

        static void Main(string[] args)
        {
            ReadInput();
            BigInteger tempDigit = ConvertToBaseTen(N, s);
            if (d == 10)
            {
                Console.WriteLine(tempDigit);
            }
            else
            {
                string result = ConvertToBaseD(tempDigit, d);
                Console.WriteLine(result);
            }                    
        }

        private static string ConvertToBaseD(BigInteger tempDigit, int d)
        {
            string tempResult = "";
            BigInteger temp = new BigInteger();            

            while (tempDigit != 0)
            {
                temp = tempDigit % d;
                if (temp < 10)
                {
                    tempResult += string.Join("", temp);
                }
                else
                {
                    tempResult += string.Join("", map[(int)temp - 10]);
                }
                tempDigit = tempDigit / d;
            }
            if (tempResult == "")
            {
                tempResult = "0";
            }
            tempResult = StringReverse(tempResult);
            return tempResult;
        }

        private static string StringReverse(string result)
        {
            char[] temp = result.ToArray();
            Array.Reverse(temp);
            return new string(temp);
        }

        private static BigInteger ConvertToBaseTen(string digit, int s)
        {
            BigInteger result = 0;
            BigInteger tempValue = 0;
            for (int i = 0; i < digit.Length; i++)
            {
                if ((digit[i] - '0') < 10)
                {
                    tempValue = digit[i] - '0';
                }
                else
                {
                    tempValue = Array.FindIndex(map, w => w.Equals(digit[i])) + 10;                    
                }
                result = s * result + tempValue;
            }
            return result;
        }       
        
        private static void ReadInput()
        {
            s = int.Parse(Console.ReadLine());
            N = Console.ReadLine();
            d = int.Parse(Console.ReadLine());
        }
    }
}

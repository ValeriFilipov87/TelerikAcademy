using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Reverse_Number
{
    class ReverseNumber
    {
        public static int arrayLength = new int();
        public static string arrayInput = "";
        static void Main(string[] args)
        {
            ReadInputData();
            string[] number = ReverseDigit(arrayInput);
            PrintAnswer(number);
        }

        private static void PrintAnswer(string[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }

        private static string[] ReverseDigit(string arrayInput)
        {
            char[] input = arrayInput.ToCharArray();
            string[] answer = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                answer[i] = input[input.Length - 1 - i].ToString();
            }
            return answer;
        }

        private static void ReadInputData()
        {
            //arrayLength = int.Parse(Console.ReadLine());
            arrayInput = Console.ReadLine();
        }
    }
}

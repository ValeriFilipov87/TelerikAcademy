using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Appearance_Count
{
    class AppearanceCount
    {
        public static int arrayLength = new int();
        public static string arrayInput = "";
        public static int digit = new int();

        static void Main(string[] args)
        {
            ReadInputData();
            int[] arrayDigits = ConvertStringToIntArray(arrayInput);
            PrintApperanceCount(arrayDigits, digit);            
        }

        private static void PrintApperanceCount(int[] arrayDigits, int digit)
        {
            int count = new int();
            for (int i = 0; i < arrayDigits.Length; i++)
            {
                if (arrayDigits[i] == digit)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static int[] ConvertStringToIntArray(string arrayInput)
        {
            string[] tempArray = arrayInput.Split(' ').ToArray();
            int[] data = new int[tempArray.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = int.Parse(tempArray[i]);
            }
            return data;
        }

        private static void ReadInputData()
        {
            arrayLength = int.Parse(Console.ReadLine());
            arrayInput = Console.ReadLine();
            digit = int.Parse(Console.ReadLine());
        }
    }
}

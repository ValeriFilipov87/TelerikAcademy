using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Larger_Than_Neighbours
{
    class LargerThanNeighbours
    {
        public static int arrayLength = new int();
        public static string arrayInput = "";
        
        static void Main(string[] args)
        {
            ReadInputData();
            int[] arrayDigits = ConvertStringToIntArray(arrayInput);
            FindLargerNeighbours(arrayDigits);
        }

        private static void FindLargerNeighbours(int[] arrayDigits)
        {
            int count = new int();
            for (int i = 1; i < arrayDigits.Length-1; i++)
            {
                if (arrayDigits[i] > arrayDigits[i-1] && arrayDigits[i] > arrayDigits[i+1])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void ReadInputData()
        {
            arrayLength = int.Parse(Console.ReadLine());
            arrayInput = Console.ReadLine();
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
    }
}

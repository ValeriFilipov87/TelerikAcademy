using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_First_Larger_Than_Neighbour
{
    class FirstLargerThanNeighbour
    {
        public static int arrayLength = new int();
        public static string arrayInput = "";

        static void Main(string[] args)
        {
            ReadInputData();
            int[] arrayDigits = ConvertStringToIntArray(arrayInput);
            FindFirstLargerNeighbours(arrayDigits);
        }

        private static void FindFirstLargerNeighbours(int[] arrayDigits)
        {
            bool isThereDigit = false;
            for (int i = 1; i < arrayDigits.Length - 1; i++)
            {
                if (arrayDigits[i] > arrayDigits[i - 1] && arrayDigits[i] > arrayDigits[i + 1])
                {
                    Console.WriteLine(i);
                    isThereDigit = true;
                    break;
                }                
            }
            if (!isThereDigit)
            {
                Console.WriteLine(-1);
            }

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

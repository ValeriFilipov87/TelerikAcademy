using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Compare_arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Input array length: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[arrayLenght];
            int[] arrayTwo = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write("Array 1 Value {0}: ", i);
                arrayOne[i] = int.Parse(Console.ReadLine());
                Console.Write("Array 2 Value {0}: ", i);
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arrayLenght; i++)
            {
                if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine("Array 1 Value {0} {1} > Array 2 Value {0} {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine("Array 1 Value {0} {1} < Array 2 Value {0} {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else
                {
                    Console.WriteLine("Array 1 Value {0} {1} = Array 2 Value {0} {2}", i, arrayOne[i], arrayTwo[i]);
                }
            }
        }
    }
}

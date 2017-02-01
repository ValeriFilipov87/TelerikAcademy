using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] alphabet = new int[26];
            alphabet[0] = 'a';

            for (int i = 1; i < alphabet.Length; i++)
            {
                alphabet[i] = alphabet[i - 1] + 1;
            }

            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.Write((char)alphabet[i]);
                Console.Write(' ');
            }
            Console.WriteLine();


            for (int i = 0; i < input.Length; i++)
            {
                int left = 0;
                int right = alphabet.Length - 1;
                int middle = (alphabet.Length - 1) / 2;
                bool isElementFound = false;

                while (!isElementFound)
                {
                    if (input[i] > alphabet[middle])
                    {
                        left = middle + 1;
                        middle = (right + left) / 2;
                        if (input[i] == alphabet[middle])
                        {
                            isElementFound = true;
                        }
                    }
                    if (input[i] < alphabet[middle])
                    {
                        right = middle - 1;
                        middle = (right + left) / 2;
                        if (input[i] == alphabet[middle])
                        {
                            isElementFound = true;
                        }
                    }
                    if (input[i] == alphabet[middle])
                    {
                        isElementFound = true;
                    }
                }
                Console.Write(middle);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}

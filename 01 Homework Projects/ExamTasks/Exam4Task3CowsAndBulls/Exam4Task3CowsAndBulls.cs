using System;

class Exam4Task3CowsAndBulls
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] secretNumber = new int[input.Length];

        for (int j = 0; j < input.Length; j++)
        {
            if (Char.IsDigit(input[j]))
            {
                secretNumber[j] = input[j] - '0';
            }
        }
        int bullsDigit = int.Parse(Console.ReadLine());

        int cowsDigit = int.Parse(Console.ReadLine());
        bool foundNumber = false;

        for (int i = 1000; i < 10000; i++)
        {
            //fill the array for the input
            for (int j = 0; j < input.Length; j++)
            {
                if (Char.IsDigit(input[j]))
                {
                    secretNumber[j] = input[j] - '0';
                }
            }

            string tempDigitString = Convert.ToString(i);
            //check for 0 in the current digit
            if (tempDigitString.Contains("0"))
            {
                continue;
            }
            int[] tempDigit = new int[input.Length];

            // fill temp array for the current digit
            for (int j = 0; j < tempDigit.Length; j++)
            {
                if (Char.IsDigit(input[j]))
                {
                    tempDigit[j] = tempDigitString[j] - '0';
                }
            }

            //check for bulls
            int bullsCount = new int();
            for (int j = 0; j < input.Length; j++)
            {
                if (secretNumber[j] == tempDigit[j])
                {
                    bullsCount++;
                    tempDigit[j] = -1;
                    secretNumber[j] = -2;
                }
            }

            //cehck for cows
            int cowsCount = new int();
            for (int j = 0; j < input.Length; j++)
            {
                for (int p = 0; p < input.Length; p++)
                {
                    if (secretNumber[j] == tempDigit[p])
                    {
                        cowsCount++;
                        secretNumber[j] = -3;
                        tempDigit[p] = -4;
                    }
                }
            }

            //print digits
            if (bullsCount == bullsDigit && cowsCount == cowsDigit)
            {
                Console.Write(i + " ");
                foundNumber = true;
            }
        }
        if (!foundNumber)
        {
            Console.WriteLine("No");
        }
    }
}


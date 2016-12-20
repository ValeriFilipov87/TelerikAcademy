using System;

class Exam5Task2DrunkenNumbers
{
    static void Main()
    {
        int roundsNumbers = int.Parse(Console.ReadLine());
        int resultMitko = new int();
        int resultVladko = new int();

        for (int rounds = 1; rounds <= roundsNumbers; rounds++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                number *= -1;
            }
            int countDigits = 0;
            int tempNumber = number;

            while (tempNumber > 0)
            {
                tempNumber = tempNumber / 10;
                countDigits++;
            }

            for (int i = 0; i < countDigits / 2; i++)
            {
                resultVladko += number % 10;
                number = number / 10;
            }

            if (countDigits % 2 == 1)
            {
                int middle = number % 10;
                resultVladko += middle;
                resultMitko += middle;
                number = number / 10;
            }

            for (int i = 0; i < countDigits / 2; i++)
            {
                resultMitko += number % 10;
                number = number / 10;
            }
        }

        if (resultMitko > resultVladko)
        {
            Console.WriteLine("M {0}", resultMitko - resultVladko);
        }
        else if (resultMitko < resultVladko)
        {
            Console.WriteLine("V {0}", resultVladko - resultMitko);
        }
        else
        {
            Console.WriteLine("No {0}", resultMitko + resultVladko);
        }
    }
}


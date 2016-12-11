using System;

class Exam4Task4NeuronMapping
{
    static void Main()
    {
        while (true)
        {
            long input = long.Parse(Console.ReadLine());
            if (input == -1)
            {
                break;
            }
            long result = input;
            int mostRight = -1;
            int mostLeft = -1;
            for (int currentCol = 0; currentCol < 32; currentCol++)
            {
                long mask = 1L << currentCol;
                long zeroMask = ~(1L << currentCol);
                long nAndMask = mask & input;
                long currentBit = nAndMask >> currentCol;
                if (currentBit == 1 && mostRight == -1)
                {
                    mostRight = currentCol;
                }
                if (currentBit == 1)
                {
                    mostLeft = currentCol;
                }
            }
            for (int currentCol = mostRight; currentCol <= mostLeft; currentCol++)
            {
                if (mostLeft == -1 && mostRight == -1)
                {
                    break;
                }
                long mask = 1L << currentCol;
                long zeroMask = ~(1L << currentCol);
                long nAndMask = mask & input;
                long currentBit = nAndMask >> currentCol;
                if (currentBit == 0)
                {
                    result = result | mask;
                }
                if (currentBit == 1)
                {
                    result = result & zeroMask;
                }
            }
            Console.WriteLine(result);
        }
    }
}


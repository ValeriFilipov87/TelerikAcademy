using System;

class Exam3Task5Smetalo
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());

        long row0 = long.Parse(Console.ReadLine());
        long row1 = long.Parse(Console.ReadLine());
        long row2 = long.Parse(Console.ReadLine());
        long row3 = long.Parse(Console.ReadLine());
        long row4 = long.Parse(Console.ReadLine());
        long row5 = long.Parse(Console.ReadLine());
        long row6 = long.Parse(Console.ReadLine());
        long row7 = long.Parse(Console.ReadLine());

        //Console.WriteLine(Convert.ToString(row0, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(row1, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(row2, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(row3, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(row4, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(row5, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(row6, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(row7, 2).PadLeft(32, '0'));

        string commandReset = "reset";
        string commandRight = "right";
        string commandLeft = "left";
        string commandStop = "stop";

        while (true)
        {
            string command = Console.ReadLine();

            if (command == commandStop)
            {
                int row = 0;
                int col = 0;
                long currentRow = new long();
                long bit = new int();
                int count = new int();
                long result = new int();
                switch (row)
                {
                    case 0: currentRow = row0; break;
                    case 1: currentRow = row1; break;
                    case 2: currentRow = row2; break;
                    case 3: currentRow = row3; break;
                    case 4: currentRow = row4; break;
                    case 5: currentRow = row5; break;
                    case 6: currentRow = row6; break;
                    case 7: currentRow = row7; break;
                }
                for (col = 0; col < width; col++)
                {
                    long mask = 1L << col;
                    long nandMask = (long)mask & currentRow;
                    bit = nandMask >> col;
                   
                    if (bit == 0)
                    {
                        count++;
                    }
                    result = 8 * currentRow * count;                                    
                }
                Console.WriteLine(result);
                break;
            }
            if (command == commandRight || command == commandLeft)
            {
                if (command == commandRight)
                {
                    int row = int.Parse(Console.ReadLine());
                    int col = width - int.Parse(Console.ReadLine());
                    long currentRow = new int();
                    long bit = new int();
                    int currentBitPosition = new int();
                    int lastBitPosition = new int();
                    switch (row)
                    {
                        case 0: currentRow = row0; break;
                        case 1: currentRow = row1; break;
                        case 2: currentRow = row2; break;
                        case 3: currentRow = row3; break;
                        case 4: currentRow = row4; break;
                        case 5: currentRow = row5; break;
                        case 6: currentRow = row6; break;
                        case 7: currentRow = row7; break;
                    }
                    for (int i = 0; i < width - col; i++)
                    {
                        int mask = 1 << i;
                        long nandMask = mask & currentRow;
                        bit = nandMask >> i;
                        currentBitPosition = i;

                        if (bit == 1)
                        {
                            if (currentBitPosition != lastBitPosition)
                            {
                                mask = ~(1 << currentBitPosition);
                                currentRow = currentRow & mask;
                                mask = 1 << lastBitPosition;
                                currentRow = currentRow | mask;
                                lastBitPosition++;
                            }
                        }
                    }
                    //Console.WriteLine(currentRow);
                }
                else
                {
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());
                    long currentRow = new int();
                    long bit = new int();
                    int currentBitPosition = new int();
                    int firstBitPosition = width - 1;
                    switch (row)
                    {
                        case 0: currentRow = row0; break;
                        case 1: currentRow = row1; break;
                        case 2: currentRow = row2; break;
                        case 3: currentRow = row3; break;
                        case 4: currentRow = row4; break;
                        case 5: currentRow = row5; break;
                        case 6: currentRow = row6; break;
                        case 7: currentRow = row7; break;
                    }
                    for (int i = width - 1; i >= width - 1 - col; i--)
                    {
                        int mask = 1 << i;
                        long nandMask = mask & currentRow;
                        bit = nandMask >> i;
                        currentBitPosition = i;

                        if (firstBitPosition == i && bit == 1)
                        {
                            firstBitPosition--;
                            continue;
                        }
                        if (currentBitPosition != firstBitPosition)
                        {
                            if (bit == 1)
                            {
                                mask = ~(1 << currentBitPosition);
                                currentRow = currentRow & mask;
                                mask = 1 << firstBitPosition;
                                currentRow = currentRow | mask;
                                firstBitPosition--;
                            }
                        }
                    }
                    //Console.WriteLine(currentRow);
                    //Console.WriteLine(Convert.ToString(currentRow, 2).PadLeft(32, '0'));

                }
            }
            if (command == commandReset)
            {
                for (int row = 0; row < 8; row++)
                {
                    int col = width - 1;
                    long currentRow = new int();
                    long bit = new int();
                    int currentBitPosition = new int();
                    int firstBitPosition = width - 1;
                    switch (row)
                    {
                        case 0: currentRow = row0; break;
                        case 1: currentRow = row1; break;
                        case 2: currentRow = row2; break;
                        case 3: currentRow = row3; break;
                        case 4: currentRow = row4; break;
                        case 5: currentRow = row5; break;
                        case 6: currentRow = row6; break;
                        case 7: currentRow = row7; break;
                    }
                    for (int i = width - 1; i >= width - 1 - col; i--)
                    {
                        int mask = 1 << i;
                        long nandMask = mask & currentRow;
                        bit = nandMask >> i;
                        currentBitPosition = i;
                        if (firstBitPosition == i && bit == 1)
                        {
                            firstBitPosition--;
                            continue;
                        }
                        if (currentBitPosition != firstBitPosition)
                        {
                            if (bit == 1)
                            {
                                mask = ~(1 << currentBitPosition);
                                currentRow = currentRow & mask;
                                mask = 1 << firstBitPosition;
                                currentRow = currentRow | mask;
                                firstBitPosition--;
                            }
                        }
                    }
                    switch (row)
                    {
                        case 0: row0 = currentRow; break;
                        case 1: row1 = currentRow; break;
                        case 2: row2 = currentRow; break;
                        case 3: row3 = currentRow; break;
                        case 4: row4 = currentRow; break;
                        case 5: row5 = currentRow; break;
                        case 6: row6 = currentRow; break;
                        case 7: row7 = currentRow; break;
                    }
                }

                //Console.WriteLine(Convert.ToString(row0, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(row1, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(row2, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(row3, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(row4, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(row5, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(row6, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(row7, 2).PadLeft(32, '0'));
            }
        }
    }
}


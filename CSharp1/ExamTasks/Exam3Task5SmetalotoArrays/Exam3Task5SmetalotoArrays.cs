using System;
using System.Text;

class Exam3Task5SmetalotoArrays
{
    static void Main()
    {
        int arrayCol = int.Parse(Console.ReadLine());
        int arrayRow = 8;

        long[,] smetalo = new long[arrayRow, 1];

        for (int row = 0; row < arrayRow; row++)
        {
            smetalo[row, 0] = long.Parse(Console.ReadLine());
        }

        long[,] smetaloBin = new long[arrayRow, arrayCol];

        for (int row = 0; row < arrayRow; row++)
        {
            string currentLine = Convert.ToString(smetalo[row, 0], 2).PadLeft(arrayCol, '0');

            for (int col = 0; col < arrayCol; col++)
            {
                char currentSymbol = currentLine[col];
                smetaloBin[row, col] = currentSymbol - '0';
            }
        }

        //check the grid of smetalo

        //for (int row = 0; row < arrayRow; row++)
        //{
        //    for (int col = 0; col < arrayCol; col++)
        //    {
        //        Console.Write(smetaloBin[row, col]);
        //    }
        //    Console.WriteLine();
        //}

        string commandReset = "reset";
        string commandRight = "right";
        string commandLeft = "left";
        string commandStop = "stop";

        while (true)
        {
            string command = Console.ReadLine();            

            //operate reset
            if (command == commandReset)
            {
                for (int row = 0; row < arrayRow; row++)
                {
                    int countOfOnes = 0;
                    for (int col = 0; col < arrayCol; col++)
                    {
                        if (smetaloBin[row, col] == 1)
                        {
                            countOfOnes++;
                            smetaloBin[row, col] = 0;
                        }
                    }
                    for (int col = 0; col < countOfOnes; col++)
                    {
                        smetaloBin[row, col] = 1;
                    }
                }
                continue;
            }

            if (command == commandStop)
            {
                break;
            }

            //read value for row

            int currentRow = int.Parse(Console.ReadLine());
            if (currentRow < 0)
            {
                currentRow = 0;
            }
            if (currentRow > arrayRow - 1)
            {
                currentRow = arrayRow - 1;
            }

            //read value for col
            int currentCol = int.Parse(Console.ReadLine());
            if (currentCol < 0)
            {
                currentCol = 0;
            }
            if (currentCol > arrayCol - 1)
            {
                currentCol = arrayCol - 1;
            }

            //operate right
            if (command == commandRight)
            {
                int count = new int();
                for (int col = currentCol; col < arrayCol; col++)
                {
                    if (smetaloBin[currentRow, col] == 1)
                    {
                        smetaloBin[currentRow, col] = 0;
                        count++;
                    }
                }
                for (int col = arrayCol - 1; col > arrayCol - 1 - count; col--)
                {
                    smetaloBin[currentRow, col] = 1;
                }
            }

            //operate left

            if (command == commandLeft)
            {
                int count = new int();
                for (int col = 0; col <= currentCol; col++)
                {
                    if (smetaloBin[currentRow, col] == 1)
                    {
                        smetaloBin[currentRow, col] = 0;
                        count++;
                    }
                }
                for (int col = 0; col < count; col++)
                {
                    smetaloBin[currentRow, col] = 1;
                }
            }
        }

        // convert binary digits to decimal and calculate the sum
        long result = 0;
        for (int row = 0; row < arrayRow; row++)
        {
            StringBuilder sb = new StringBuilder();

            for (int col = 0; col < arrayCol; col++)
            {
                sb.Append(smetaloBin[row, col]);
            }

            long currNum = Convert.ToInt64(sb.ToString(), 2);
            result = result + currNum;
        }

        // check the empty columns
        int countOfZeroCol = 0;
        for (int col = 0; col < arrayCol; col++)
        {
            bool isEmpty = true;
            for (int row = 0; row < arrayRow; row++)
            {

                if (smetaloBin[row, col] == 1)
                {
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                countOfZeroCol++;
            }
        }
        Console.WriteLine(countOfZeroCol * result);
    }
}


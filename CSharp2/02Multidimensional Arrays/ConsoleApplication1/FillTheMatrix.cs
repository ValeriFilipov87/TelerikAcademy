using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            string solution = Console.ReadLine();
            int[,] spiral = new int[matrixSize, matrixSize];

            switch (solution)
            {
                case "a": spiral = SolutionA(spiral); PrintSpiral(spiral); break;
                case "b": spiral = SolutionB(spiral); PrintSpiral(spiral); break;
                case "c": spiral = SolutionC(spiral); PrintSpiral(spiral); break;
                case "d": spiral = SolutionD(spiral); PrintSpiral(spiral); break;
            }
        }

        private static int[,] SolutionD(int[,] array)
        {
            string direction = "down";
            int digit = 1;
            int rowEnd = array.GetLength(0);
            int colEnd = array.GetLength(1);
            int rowEE = 0;
            int colEE = 0;
            int r = 0;
            int c = 0;

            while (digit != (array.GetLength(0) * array.GetLength(1) + 1))
            {
                if (direction == "down" || direction == "rigth")
                {
                    for (int row = r; row < rowEnd; row++)
                    {
                        for (int col = c; col < colEnd; col++)
                        {
                            if (direction == "down")
                            {
                                array[row, col] = digit;
                                digit++;
                                if (row + 1 == array.GetLength(0) || array[row + 1, col] != 0)
                                {
                                    direction = "rigth";
                                    r = row;
                                    c = col + 1;
                                }
                                break;
                            }
                            if (direction == "rigth")
                            {
                                array[row, col] = digit;
                                digit++;
                                if (col + 1 == array.GetLength(1) || array[row, col + 1] != 0)
                                {
                                    direction = "up";
                                    c = col;
                                    r = row - 1;
                                    rowEnd--;
                                    colEnd--;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int row = r; row >= rowEE; row--)
                    {
                        for (int col = c; col >= colEE; col--)
                        {
                            if (direction == "up")
                            {
                                array[row, col] = digit;
                                digit++;
                                if (row - 1 < 0 || array[row - 1, col] != 0)
                                {
                                    direction = "left";
                                    r = row;
                                    c = col - 1;
                                }
                                break;
                            }
                            if (direction == "left")
                            {
                                array[row, col] = digit;
                                digit++;
                                if (col - 1 < 0 || array[row, col - 1] != 0)
                                {
                                    direction = "down";
                                    c = col;
                                    r = row + 1;
                                    rowEE++;
                                    colEnd++;
                                }
                            }
                        }
                    }
                }
            }

            return array;
        }
        private static int[,] SolutionC(int[,] array)
        {
            int digit = 1;
            int x = array.GetLength(0) - 1;
            int y = 0;

            for (int row = array.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    if (x > array.GetLength(0) - 1)
                    {
                        x = row - 1;
                        y = 0;
                        break;
                    }
                    array[x, y] = digit;
                    x++;
                    y++;
                    digit++;
                }
            }
            x = 0;
            y = 1;
            for (int col = 1; col < array.GetLength(1); col++)
            {
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    if (y > array.GetLength(1) - 1)
                    {
                        x = 0;
                        y = col + 1;
                        break;
                    }
                    array[x, y] = digit;
                    x++;
                    y++;
                    digit++;
                }
            }
            return array;
        }
        private static int[,] SolutionB(int[,] array)
        {
            int digit = 1;
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < array.GetLength(0); row++)
                    {
                        array[row, col] = digit;
                        digit++;
                    }
                }
                else
                {
                    for (int row = array.GetLength(0) - 1; row >= 0; row--)
                    {
                        array[row, col] = digit;
                        digit++;
                    }
                }

            }
            return array;
        }
        private static int[,] SolutionA(int[,] array)
        {
            int digit = 1;

            for (int col = 0; col < array.GetLength(1); col++)
            {
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    array[row, col] = digit;
                    digit++;
                }
            }
            return array;
        }
        private static void PrintSpiral(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0, -4}", array[row, col]);
                    if (col < array.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

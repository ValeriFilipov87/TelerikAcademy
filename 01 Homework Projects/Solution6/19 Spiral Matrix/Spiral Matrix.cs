/*  Problem 19.** Spiral Matrix

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

*/

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Input a positive number: ");
        int m = UserInput();
        int[,] matrix = new int[m, m];
        int row = 0;
        int col = 0;
        string direction = "rigth";
        int maxRot = m * m;
        for (int i = 1; i <= maxRot; i++)
        {
            if (direction == "rigth" && (col > m - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > m - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                col--;
                row--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "rigth";
                col++;
                row++;
            }

            matrix[row, col] = i;

            if (direction == "rigth")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        printMatrix(matrix, m);

    }

    private static void printMatrix(int[,] matrix, int m)
    {
        Console.WriteLine();
        for (int r = 0; r < m; r++)
        {
            for (int c = 0; c < m; c++)
            {
                Console.Write("{0,4}", matrix[r, c]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static int UserInput()
    {
        int input = new int();
        bool check = int.TryParse(Console.ReadLine(), out input);
        while (!check)
        {
            Console.WriteLine("The input is wrong!");
            check = int.TryParse(Console.ReadLine(), out input);
        }
        return input;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string[] matrixSize = size.Split(' ').ToArray();
            int N = int.Parse(matrixSize[0]);
            int M = int.Parse(matrixSize[1]);
            long[,] matrix = new long[N, M];

            for (int row = 0; row < N; row++)
            {
                string input = Console.ReadLine();
                string[] inputValues = input.Split(' ').ToArray();
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = int.Parse(inputValues[col]);
                }
            }
            long currentSum = 0;
            long maxSum = long.MinValue;
            int iterationI = 0;
            int iterationJ = 0;
            for (int row = 1; row < N - 1; row++)
            {
                for (int col = 1; col < M - 1; col++)
                {
                    for (int i = row - 1; i < 3 + iterationI; i++)
                    {
                        for (int j = col - 1; j < 3 + iterationJ; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }
                    iterationJ++;
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                    }
                    currentSum = 0;
                }
                iterationI++;
                iterationJ = 0;
            }
            Console.WriteLine(maxSum);
        }
    }
}

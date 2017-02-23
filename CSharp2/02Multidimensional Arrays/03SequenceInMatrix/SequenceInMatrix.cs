using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string[] matrixSize = size.Split(' ').ToArray();
            int N = int.Parse(matrixSize[0]);
            int M = int.Parse(matrixSize[1]);
            string[,] matrix = new string[N, M];

            for (int row = 0; row < N; row++)
            {
                string input = Console.ReadLine();
                string[] inputValues = input.Split(' ').ToArray();
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = inputValues[col];
                }
            }

            int currentSequence = 1;
            int maxSequence = 1;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    int counter = 1;
                    currentSequence = 1;
                    while (true)
                    {
                        if (col + counter < M)
                        {
                            bool result = matrix[row, col].Equals(matrix[row, col + counter], StringComparison.Ordinal);
                            if (result)
                            {
                                currentSequence++;
                            }
                            else if (result == false)
                            {
                                break;
                            }
                            counter++;
                            if (currentSequence > maxSequence)
                            {
                                maxSequence = currentSequence;
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                    counter = 1;
                    currentSequence = 1;
                    while (true)
                    {
                        if (row + counter < N)
                        {
                            bool result = matrix[row, col].Equals(matrix[row + counter, col], StringComparison.Ordinal);
                            if (result)
                            {
                                currentSequence++;
                            }
                            else if (result == false)
                            {
                                break;
                            }
                            counter++;
                            if (currentSequence > maxSequence)
                            {
                                maxSequence = currentSequence;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    counter = 1;
                    currentSequence = 1;
                    while (true)
                    {
                        if (row + counter < N && col + counter < M)
                        {
                            bool result = matrix[row, col].Equals(matrix[row + counter, col + counter], StringComparison.Ordinal);
                            if (result)
                            {
                                currentSequence++;
                            }
                            else if (result == false)
                            {
                                break;
                            }
                            counter++;
                            if (currentSequence > maxSequence)
                            {
                                maxSequence = currentSequence;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    counter = 1;
                    currentSequence = 1;
                    while (true)
                    {
                        if (row + counter < N && col - counter >= 0)
                        {
                            bool result = matrix[row, col].Equals(matrix[row + counter, col - counter], StringComparison.Ordinal);
                            if (result)
                            {
                                currentSequence++;
                            }
                            else if (result == false)
                            {
                                break;
                            }
                            counter++;
                            if (currentSequence > maxSequence)
                            {
                                maxSequence = currentSequence;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}

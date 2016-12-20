using System;

class Program
{
    static void Main()
    {
        int rounds = int.Parse(Console.ReadLine());
        int boardRow = 4;
        int boardCol = 8;
        int[,] board = new int[boardRow, boardCol];
        bool[,] isEmpty = new bool[boardRow, boardCol];
        for (int emptyRow = 0; emptyRow < boardRow; emptyRow++)
        {
            for (int emptyCol = 0; emptyCol < boardCol; emptyCol++)
            {
                isEmpty[emptyRow, emptyCol] = true;
            }
        }

        int currentRow = 0;

        string commandDown = "D";
        string commandLeft = "L";
        string commandRight = "R";

        for (int i = 0; i < rounds; i++)
        {
            string command = Console.ReadLine();
            int inputDigit = new int();

            bool isNewDigit = int.TryParse(command, out inputDigit);
            if (isNewDigit)
            {
                string currentLine = Convert.ToString(inputDigit, 2).PadLeft(boardCol, '0');
                for (int col = 0; col < boardCol; col++)
                {
                    char currentSymbol = currentLine[col];
                    currentRow = 0;
                    board[currentRow, col] = currentSymbol - '0';
                }
            }
            else
            {
                if (command == commandDown)
                {
                    if (currentRow < boardRow - 1)
                    {
                        for (int col = 0; col < boardCol; col++)
                        {
                            if (board[currentRow + 1, col] == 1)
                            {
                                isEmpty = false;
                            }
                        }
                        if (isEmpty)
                        {
                            for (int col = 0; col < boardCol; col++)
                            {
                                board[currentRow + 1, col] = board[currentRow, col];
                                board[currentRow, col] = 0;
                            }
                        }
                        currentRow++;
                    }
                }
                if (command == commandRight)
                {
                    if (board[currentRow, boardCol - 1] == 0)
                    {
                        for (int curCol = boardCol - 1; curCol > 0; curCol--)
                        {
                            board[currentRow, curCol] = board[currentRow, curCol - 1];
                            if (curCol - 1 == 0)
                            {
                                board[currentRow, curCol - 1] = 0;
                            }
                        }

                        if (currentRow < boardRow - 1)
                        {
                            for (int col = 0; col < boardCol; col++)
                            {
                                if (board[currentRow + 1, col] == 1)
                                {
                                    isEmpty[currentRow + 1, col] = false;
                                }
                            }
                            for (int col = 0; col < boardCol; col++)
                            {
                                if (isEmpty[currentRow+1,col])
                                {
                                    board[currentRow + 1, col] = board[currentRow, col];
                                    board[currentRow, col] = 0;
                                }                                
                            }

                            currentRow++;
                        }
                    }
                }
                if (command == commandLeft)
                {
                    if (board[currentRow, 0] == 0)
                    {
                        for (int curCol = 0; curCol < boardCol - 1; curCol++)
                        {
                            board[currentRow, curCol] = board[currentRow, curCol + 1];
                            if (curCol + 1 == boardCol - 1)
                            {
                                board[currentRow, curCol + 1] = 0;
                            }
                        }
                        if (currentRow < boardRow - 1)
                        {
                            for (int col = 0; col < boardCol; col++)
                            {
                                if (board[currentRow + 1, col] == 1)
                                {
                                    isEmpty = false;
                                }
                            }
                            if (isEmpty)
                            {
                                for (int col = 0; col < boardCol; col++)
                                {
                                    board[currentRow + 1, col] = board[currentRow, col];
                                    board[currentRow, col] = 0;
                                }
                            }
                            currentRow++;
                        }
                    }
                }
            }

            for (int row = 0; row < boardRow; row++)
            {
                for (int col = 0; col < boardCol; col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}


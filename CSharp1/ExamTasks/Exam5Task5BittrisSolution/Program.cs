using System;
class Bittris
{
    static bool CheckFilledRow(int index, int[] playingField)
    {
        bool filledRow = false;
        if (playingField[index] == 255)
        {
            filledRow = true;
        }
        return filledRow;
    }

    static void FixFilledRow(int index, int[] field)
    {
        for (int i = index; i > 0; i--)
        {
            field[i] = field[i - 1];
        }
        field[0] = 0;
    }

    static void EliminateUnneededOneBits(ref int n)
    {
        n &= 255;
    }

    static int NumberOfOneBits(int n)
    {
        int count = 0;
        int mask = 1;
        while (n != 0)
        {
            if ((n & mask) == 1)
            {
                count++;
            }
            n >>= 1;
        }
        return count;
    }

    static bool MoveDown(ref int index, int number, int[] field)
    {
        bool movedDown = false;
        if (index != 3)//ако не е най-отдолу
        {
            if ((number & field[index + 1]) == 0) //ако числото и долният ред нямат съвпадащи 1
            {
                field[index + 1] |= number;       //добавяме към долния ред нашето число
                field[index] ^= number;           //и го премахваме от горния ред
                index++;                          //помним, че числото ни вече е на долния ред (currentRow++)
                movedDown = true;
            }
        }
        return movedDown;
    }

    static void MoveLeft(int index, ref int number, int[] field)
    {
        if ((number & 128) == 0) //ако числото не е плътно вляво
        {
            if (number == field[index]) //ако редът е съставен само от текущото число
            {
                field[index] <<= 1;  //директно го изместваме
                number <<= 1;
            }
            else                        //ако в реда има единици, непринадлежащи на текущото число
            {
                int help = field[index];
                help ^= number;
                if ((help & (number << 1)) == 0) //проверяваме дали има място да отместим текущото число без да се блъснем
                {
                    field[index] ^= number;
                    number <<= 1;
                    field[index] |= number;
                }
            }
        }
    }

    static void MoveRight(int index, ref int number, int[] field) //аналогично на MoveLeft
    {
        if ((number & 1) == 0)
        {
            if (number == field[index])
            {
                field[index] >>= 1;
                number >>= 1;
            }
            else
            {
                int help = field[index];
                help ^= number;
                if ((help & (number >> 1)) == 0)
                {
                    field[index] ^= number;
                    number >>= 1;
                    field[index] |= number;
                }
            }
        }
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] playingField = new int[4];
        int number = 0;
        int currentRow = 0;
        int currentScore = 0;
        int totalScore = 0;
        bool hasLanded = false;
        for (int i = 0; i < N; i++)
        {
            if (i % 4 == 0) //време е за ново число
            {
                number = int.Parse(Console.ReadLine());
                currentRow = 0;
                currentScore = NumberOfOneBits(number);
                hasLanded = false;
                EliminateUnneededOneBits(ref number);
                playingField[0] = number;
            }
            else  //въвеждаме команда
            {
                char command = char.Parse(Console.ReadLine());
                if (!hasLanded) //ако сме се приземили, командата се игнорира, ако не -> влизаме в if-a
                {
                    switch (command)
                    {
                        case 'D': break;
                        case 'R': MoveRight(currentRow, ref number, playingField); break;
                        case 'L': MoveLeft(currentRow, ref number, playingField); break;
                        default: break;
                    }
                    bool movedDown = MoveDown(ref currentRow, number, playingField);
                    if (!movedDown || currentRow == 3)
                    {
                        hasLanded = true;
                        if (CheckFilledRow(currentRow, playingField))
                        {
                            FixFilledRow(currentRow, playingField);
                            currentScore *= 10;
                        }
                        totalScore += currentScore;
                        if (playingField[0] != 0) //числото се е приземило -> ако на първия ред има единици, играта приключва
                        {
                            break;
                        }
                    }
                }
            }
        }
        Console.Write(totalScore);
    }
}
using System;

class Exam2Task5Warhead
{
    static void Main()
    {
        // define the field
        int row0 = Convert.ToInt32(Console.ReadLine(), 2);
        int row1 = Convert.ToInt32(Console.ReadLine(), 2);
        int row2 = Convert.ToInt32(Console.ReadLine(), 2);
        int row3 = Convert.ToInt32(Console.ReadLine(), 2);
        int row4 = Convert.ToInt32(Console.ReadLine(), 2);
        int row5 = Convert.ToInt32(Console.ReadLine(), 2);
        int row6 = Convert.ToInt32(Console.ReadLine(), 2);
        int row7 = Convert.ToInt32(Console.ReadLine(), 2);
        int row8 = Convert.ToInt32(Console.ReadLine(), 2);
        int row9 = Convert.ToInt32(Console.ReadLine(), 2);
        int row10 = Convert.ToInt32(Console.ReadLine(), 2);
        int row11 = Convert.ToInt32(Console.ReadLine(), 2);
        int row12 = Convert.ToInt32(Console.ReadLine(), 2);
        int row13 = Convert.ToInt32(Console.ReadLine(), 2);
        int row14 = Convert.ToInt32(Console.ReadLine(), 2);
        int row15 = Convert.ToInt32(Console.ReadLine(), 2);

        // define commands
        string commandEnd = "cut";
        string commandHover = "hover";
        string commandOperate = "operate";
        string commandLeft = "red";
        string commandRight = "blue";


        int countBlueFigure = new int();
        int countRedFigure = new int();
        int upperRow = new int();
        int middleRow = new int();
        int lowerRow = new int();
        bool isGameOn = true;
        bool isFigure = false;

        //check count of figures

        int rowCheck0 = row0;
        int rowCheck1 = row1;
        int rowCheck2 = row2;
        int rowCheck3 = row3;
        int rowCheck4 = row4;
        int rowCheck5 = row5;
        int rowCheck6 = row6;
        int rowCheck7 = row7;
        int rowCheck8 = row8;
        int rowCheck9 = row9;
        int rowCheck10 = row10;
        int rowCheck11 = row11;
        int rowCheck12 = row12;
        int rowCheck13 = row13;
        int rowCheck14 = row14;
        int rowCheck15 = row15;

        for (int r = 0; r < 16; r++)
        {
            for (int c = 0; c < 16; c++)
            {
                switch (r)
                {
                    case 0: upperRow = 0; middleRow = rowCheck0; lowerRow = rowCheck1; break;
                    case 1: upperRow = rowCheck0; middleRow = rowCheck1; lowerRow = rowCheck2; break;
                    case 2: upperRow = rowCheck1; middleRow = rowCheck2; lowerRow = rowCheck3; break;
                    case 3: upperRow = rowCheck2; middleRow = rowCheck3; lowerRow = rowCheck4; break;
                    case 4: upperRow = rowCheck3; middleRow = rowCheck4; lowerRow = rowCheck5; break;
                    case 5: upperRow = rowCheck4; middleRow = rowCheck5; lowerRow = rowCheck6; break;
                    case 6: upperRow = rowCheck5; middleRow = rowCheck6; lowerRow = rowCheck7; break;
                    case 7: upperRow = rowCheck6; middleRow = rowCheck7; lowerRow = rowCheck8; break;
                    case 8: upperRow = rowCheck7; middleRow = rowCheck8; lowerRow = rowCheck9; break;
                    case 9: upperRow = rowCheck8; middleRow = rowCheck9; lowerRow = rowCheck10; break;
                    case 10: upperRow = rowCheck9; middleRow = rowCheck10; lowerRow = rowCheck11; break;
                    case 11: upperRow = rowCheck10; middleRow = rowCheck11; lowerRow = rowCheck12; break;
                    case 12: upperRow = rowCheck11; middleRow = rowCheck12; lowerRow = rowCheck13; break;
                    case 13: upperRow = rowCheck12; middleRow = rowCheck13; lowerRow = rowCheck14; break;
                    case 14: upperRow = rowCheck13; middleRow = rowCheck14; lowerRow = rowCheck15; break;
                    case 15: upperRow = rowCheck14; middleRow = rowCheck15; lowerRow = 0; break;
                }

                int mask = 1 << c;

                // check for a center
                bool isCenter = (middleRow & mask) == 0;

                //check for a figure
                // check for whole cookie
                if (c == 0)
                {
                    continue;
                }

                isFigure =
                   isCenter && (
                   //upper
                   ((upperRow & (1 << (c - 1))) != 0) &&
                   ((upperRow & (1 << c)) != 0) &&
                   ((upperRow & (1 << (c + 1))) != 0) &&
                   //middle
                   ((middleRow & (1 << (c - 1))) != 0) &&
                   ((middleRow & (1 << (c + 1))) != 0) &&
                   //lower
                   ((lowerRow & (1 << (c - 1))) != 0) &&
                   ((lowerRow & (1 << c)) != 0) &&
                   ((lowerRow & (1 << (c + 1))) != 0)
                   );

                if (isFigure && c <= 7)
                {
                    countBlueFigure++;
                    upperRow ^= 1 << (c - 1);
                    upperRow ^= 1 << (c);
                    upperRow ^= 1 << (c + 1);

                    middleRow ^= 1 << (c - 1);
                    middleRow ^= 0 << (c);
                    middleRow ^= 1 << (c + 1);

                    lowerRow ^= 1 << (c - 1);
                    lowerRow ^= 1 << (c);
                    lowerRow ^= 1 << (c + 1);
                    switch (r)
                    {
                        case 0: rowCheck0 = middleRow; rowCheck1 = lowerRow; break;
                        case 1: rowCheck0 = upperRow; rowCheck1 = middleRow; rowCheck2 = lowerRow; break;
                        case 2: rowCheck1 = upperRow; rowCheck2 = middleRow; rowCheck3 = lowerRow; break;
                        case 3: rowCheck2 = upperRow; rowCheck3 = middleRow; rowCheck4 = lowerRow; break;
                        case 4: rowCheck3 = upperRow; rowCheck4 = middleRow; rowCheck5 = lowerRow; break;
                        case 5: rowCheck4 = upperRow; rowCheck5 = middleRow; rowCheck6 = lowerRow; break;
                        case 6: rowCheck5 = upperRow; rowCheck6 = middleRow; rowCheck7 = lowerRow; break;
                        case 7: rowCheck6 = upperRow; rowCheck7 = middleRow; rowCheck8 = lowerRow; break;
                        case 8: rowCheck7 = upperRow; rowCheck8 = middleRow; rowCheck9 = lowerRow; break;
                        case 9: rowCheck8 = upperRow; rowCheck9 = middleRow; rowCheck10 = lowerRow; break;
                        case 10: rowCheck9 = upperRow; rowCheck10 = middleRow; rowCheck11 = lowerRow; break;
                        case 11: rowCheck10 = upperRow; rowCheck11 = middleRow; rowCheck12 = lowerRow; break;
                        case 12: rowCheck11 = upperRow; rowCheck12 = middleRow; rowCheck13 = lowerRow; break;
                        case 13: rowCheck12 = upperRow; rowCheck13 = middleRow; rowCheck14 = lowerRow; break;
                        case 14: rowCheck13 = upperRow; rowCheck14 = middleRow; rowCheck15 = lowerRow; break;
                        case 15: rowCheck14 = upperRow; rowCheck15 = middleRow; break;
                    }
                }
                if (isFigure && c >= 7)
                {
                    countRedFigure++;
                    upperRow ^= 1 << (c - 1);
                    upperRow ^= 1 << (c);
                    upperRow ^= 1 << (c + 1);

                    middleRow ^= 1 << (c - 1);
                    middleRow ^= 0 << (c);
                    middleRow ^= 1 << (c + 1);

                    lowerRow ^= 1 << (c - 1);
                    lowerRow ^= 1 << (c);
                    lowerRow ^= 1 << (c + 1);
                    switch (r)
                    {
                        case 0: rowCheck0 = middleRow; rowCheck1 = lowerRow; break;
                        case 1: rowCheck0 = upperRow; rowCheck1 = middleRow; rowCheck2 = lowerRow; break;
                        case 2: rowCheck1 = upperRow; rowCheck2 = middleRow; rowCheck3 = lowerRow; break;
                        case 3: rowCheck2 = upperRow; rowCheck3 = middleRow; rowCheck4 = lowerRow; break;
                        case 4: rowCheck3 = upperRow; rowCheck4 = middleRow; rowCheck5 = lowerRow; break;
                        case 5: rowCheck4 = upperRow; rowCheck5 = middleRow; rowCheck6 = lowerRow; break;
                        case 6: rowCheck5 = upperRow; rowCheck6 = middleRow; rowCheck7 = lowerRow; break;
                        case 7: rowCheck6 = upperRow; rowCheck7 = middleRow; rowCheck8 = lowerRow; break;
                        case 8: rowCheck7 = upperRow; rowCheck8 = middleRow; rowCheck9 = lowerRow; break;
                        case 9: rowCheck8 = upperRow; rowCheck9 = middleRow; rowCheck10 = lowerRow; break;
                        case 10: rowCheck9 = upperRow; rowCheck10 = middleRow; rowCheck11 = lowerRow; break;
                        case 11: rowCheck10 = upperRow; rowCheck11 = middleRow; rowCheck12 = lowerRow; break;
                        case 12: rowCheck11 = upperRow; rowCheck12 = middleRow; rowCheck13 = lowerRow; break;
                        case 13: rowCheck12 = upperRow; rowCheck13 = middleRow; rowCheck14 = lowerRow; break;
                        case 14: rowCheck13 = upperRow; rowCheck14 = middleRow; rowCheck15 = lowerRow; break;
                        case 15: rowCheck14 = upperRow; rowCheck15 = middleRow; break;
                    }
                }

            }
        }

        upperRow = 0;
        middleRow = 0;
        lowerRow = 0;

        while (isGameOn)
        {
            string command = Console.ReadLine();

            // end task
            if (command == commandEnd)
            {
                command = Console.ReadLine();

                if (command == commandLeft)
                {
                    if (countRedFigure != 0)
                    {
                        Console.WriteLine(countRedFigure);
                        Console.WriteLine("BOOM");
                        isGameOn = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(countBlueFigure);
                        Console.WriteLine("disarmed");
                        isGameOn = false;
                        continue;
                    }
                }
                if (command == commandRight)
                {
                    if (countBlueFigure != 0)
                    {
                        Console.WriteLine(countBlueFigure);
                        Console.WriteLine("BOOM");
                        isGameOn = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(countRedFigure);
                        Console.WriteLine("disarmed");
                        isGameOn = false;
                        continue;
                    }
                }
            }
            // read row and col for the command
            int row = int.Parse(Console.ReadLine());
            int col = 15 - int.Parse(Console.ReadLine());



            // target the row and col for the command
            switch (row)
            {
                case 0: upperRow = 0; middleRow = row0; lowerRow = row1; break;
                case 1: upperRow = row0; middleRow = row1; lowerRow = row2; break;
                case 2: upperRow = row1; middleRow = row2; lowerRow = row3; break;
                case 3: upperRow = row2; middleRow = row3; lowerRow = row4; break;
                case 4: upperRow = row3; middleRow = row4; lowerRow = row5; break;
                case 5: upperRow = row4; middleRow = row5; lowerRow = row6; break;
                case 6: upperRow = row5; middleRow = row6; lowerRow = row7; break;
                case 7: upperRow = row6; middleRow = row7; lowerRow = row8; break;
                case 8: upperRow = row7; middleRow = row8; lowerRow = row9; break;
                case 9: upperRow = row8; middleRow = row9; lowerRow = row10; break;
                case 10: upperRow = row9; middleRow = row10; lowerRow = row11; break;
                case 11: upperRow = row10; middleRow = row11; lowerRow = row12; break;
                case 12: upperRow = row11; middleRow = row12; lowerRow = row13; break;
                case 13: upperRow = row12; middleRow = row13; lowerRow = row14; break;
                case 14: upperRow = row13; middleRow = row14; lowerRow = row15; break;
                case 15: upperRow = row14; middleRow = row15; lowerRow = 0; break;
            }


            // mask for a center of a figure
            int mask = 1 << col;

            // check for a center
            bool isCenter = (middleRow & mask) == 0;

            //check for a figure
            // check for whole cookie
            if (col != 0)
            {
                isFigure =
                   isCenter && (
                   //upper
                   ((upperRow & (1 << (col - 1))) != 0) &&
                   ((upperRow & (1 << col)) != 0) &&
                   ((upperRow & (1 << (col + 1))) != 0) &&
                   //middle
                   ((middleRow & (1 << (col - 1))) != 0) &&
                   ((middleRow & (1 << (col + 1))) != 0) &&
                   //lower
                   ((lowerRow & (1 << (col - 1))) != 0) &&
                   ((lowerRow & (1 << col)) != 0) &&
                   ((lowerRow & (1 << (col + 1))) != 0)
                   );
            }
            else
            {
                isFigure = false;
            }
            // execute commands
            //hover
            if (command == commandHover)
            {
                if (isCenter)
                {
                    Console.WriteLine('-');
                }
                else
                {
                    Console.WriteLine('*');
                }
            }
            //operate
            if (command == commandOperate)
            {
                if (isCenter)
                {
                    if (isFigure)
                    {
                        upperRow ^= 1 << (col - 1);
                        upperRow ^= 1 << (col);
                        upperRow ^= 1 << (col + 1);

                        middleRow ^= 1 << (col - 1);
                        middleRow ^= 0 << (col);
                        middleRow ^= 1 << (col + 1);

                        lowerRow ^= 1 << (col - 1);
                        lowerRow ^= 1 << (col);
                        lowerRow ^= 1 << (col + 1);

                        // clean the figure after operate on it
                        switch (row)
                        {
                            case 0: row0 = middleRow; row1 = lowerRow; break;
                            case 1: row0 = upperRow; row1 = middleRow; row2 = lowerRow; break;
                            case 2: row1 = upperRow; row2 = middleRow; row3 = lowerRow; break;
                            case 3: row2 = upperRow; row3 = middleRow; row4 = lowerRow; break;
                            case 4: row3 = upperRow; row4 = middleRow; row5 = lowerRow; break;
                            case 5: row4 = upperRow; row5 = middleRow; row6 = lowerRow; break;
                            case 6: row5 = upperRow; row6 = middleRow; row7 = lowerRow; break;
                            case 7: row6 = upperRow; row7 = middleRow; row8 = lowerRow; break;
                            case 8: row7 = upperRow; row8 = middleRow; row9 = lowerRow; break;
                            case 9: row8 = upperRow; row9 = middleRow; row10 = lowerRow; break;
                            case 10: row9 = upperRow; row10 = middleRow; row11 = lowerRow; break;
                            case 11: row10 = upperRow; row11 = middleRow; row12 = lowerRow; break;
                            case 12: row11 = upperRow; row12 = middleRow; row13 = lowerRow; break;
                            case 13: row12 = upperRow; row13 = middleRow; row14 = lowerRow; break;
                            case 14: row13 = upperRow; row14 = middleRow; row15 = lowerRow; break;
                            case 15: row14 = upperRow; row15 = middleRow; break;
                        }

                        if (col <= 7)
                        {
                            countBlueFigure--;
                        }
                        else
                        {
                            countRedFigure--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("missed");
                    Console.WriteLine(countRedFigure + countBlueFigure);
                    Console.WriteLine("BOOM");
                    isGameOn = false;
                }
            }
        }
    }
}


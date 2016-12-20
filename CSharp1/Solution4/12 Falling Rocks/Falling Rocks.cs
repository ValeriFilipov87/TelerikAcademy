/*  Implement the "Falling Rocks" game in the text console.
    A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
    A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
    Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
    Ensure a constant game speed by Thread.Sleep(150).
    Implement collision detection and scoring system */


using System;
using System.Collections.Generic;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public ConsoleColor color;
    public string str;
}


class FallingRocks
{
    static void PrintOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void PrintStringOnPosition(int x, int y, string str,
       ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 15; // set the playground
        Console.BufferWidth = Console.WindowWidth = 40;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.CursorVisible = false;
        int playfieldWidth = Console.WindowWidth - 11;

        Object hero = new Object();                         // create an object for the player
        hero.x = ((Console.WindowWidth - 11) / 2) - 1;
        hero.y = Console.WindowHeight - 1;
        hero.str = "(O)";
        hero.color = ConsoleColor.Blue;

        int livesCount = 50;
        Random randomGenerator = new Random();

        List<Object> objects = new List<Object>();

        while (true)
        {
            bool hitted = false;
            {
                int chance = randomGenerator.Next(0, 100);
                if (chance < 10)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.str = "@@@";
                    newObject.x = randomGenerator.Next(0, playfieldWidth - 2);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else if (chance < 20)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Red;
                    newObject.str = "**";
                    newObject.x = randomGenerator.Next(0, playfieldWidth - 1);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Green;
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    newObject.str = "#";
                    objects.Add(newObject);
                }
            }
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);     //move player
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (hero.x - 1 >= 0)
                    {
                        hero.x = hero.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (hero.x + 1 < playfieldWidth - 2)
                    {
                        hero.x = hero.x + 1;
                    }
                }
            }



            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldObject = objects[i];
                Object newRocks = new Object();
                newRocks.x = oldObject.x;
                newRocks.y = oldObject.y + 1;
                newRocks.str = oldObject.str;
                newRocks.color = oldObject.color;

                if (newRocks.str == "@@@" && newRocks.y == hero.y && newRocks.x == hero.x)
                {
                    livesCount--;
                }
                if (newRocks.str == "**" && newRocks.y == hero.y && newRocks.x == hero.x)
                {
                    livesCount--;
                }
                if (newRocks.str == "#" && newRocks.y == hero.y && newRocks.x == hero.x)
                {
                    livesCount--;
                    hitted = true;

                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(playfieldWidth + 1, 3, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(playfieldWidth + 1, 4, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newRocks.y < Console.WindowHeight)
                {
                    newList.Add(newRocks);
                }
            }
            objects = newList;
            Console.Clear();
            for (int i = 0; i < Console.WindowHeight; i++)                              // draw boarder for the playground
            {
                PrintOnPosition(playfieldWidth, i, "|", ConsoleColor.Magenta);
            }
            if (hitted)
            {
                objects.Clear();
                PrintOnPosition(hero.x, hero.y, "X", hero.color); // draw x for colission
            }
            else
            {
                PrintOnPosition(hero.x, hero.y, hero.str, hero.color); // draw player
            }
                                  
            PrintStringOnPosition(playfieldWidth + 1, 2, "Lives: " + livesCount, ConsoleColor.Red);
            //system information
            foreach (Object newObject in objects)                                       // draw rocks
            {
                PrintOnPosition(newObject.x, newObject.y, newObject.str, newObject.color);
            }
            Thread.Sleep(200);
        }
    }
}


/* Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to 
represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 
Try to compile the code.
*/

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firtsNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        byte forthNumber = 97;
        short fifthNumber = -10000;
        Console.WriteLine(@"First number {0} is ushort
Second number {1} is sbyte
Thirt number {2} is int
Forth number {3} is byte
Fifth number {4} is short"
                        ,firtsNumber,secondNumber,thirdNumber,forthNumber,fifthNumber);
    }
}


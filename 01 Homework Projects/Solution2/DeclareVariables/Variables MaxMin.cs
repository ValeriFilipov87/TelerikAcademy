/* Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to 
represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 
Try to compile the code.
*/

using System;

    class DeclareVariables
    {
        static void Main()
        {
            byte maxbyte = byte.MaxValue;
            byte minbyte = byte.MinValue;
            sbyte maxsbyte = sbyte.MaxValue;
            sbyte minsbyte = sbyte.MinValue;
            short maxshort = short.MaxValue;
            short minshort = short.MinValue;
            ushort maxushort = ushort.MaxValue;
            ushort minushort = ushort.MinValue;
            int maxint = int.MaxValue;
            int minint = int.MinValue;
            uint maxuint = uint.MaxValue;
            uint minuint = uint.MinValue;
            long maxlong = long.MaxValue;
            long minlong = long.MinValue;
            ulong maxulong = ulong.MaxValue;
            ulong minulong = ulong.MinValue;

            Console.WriteLine("byte max = {0}", maxbyte);
            Console.WriteLine("byte min = {0}", minbyte);
            Console.WriteLine("sbyte max = {0}", maxsbyte);
            Console.WriteLine("sbyte min = {0}", minsbyte);
            Console.WriteLine("short max = {0}", maxshort);
            Console.WriteLine("short min = {0}", minshort);
            Console.WriteLine("ushort max = {0}", maxushort);
            Console.WriteLine("ushort min = {0}", minushort);
            Console.WriteLine("int max = {0}", maxint);
            Console.WriteLine("int min = {0}", minint);
            Console.WriteLine("uint max = {0}", maxuint);
            Console.WriteLine("uint min = {0}", minuint);
            Console.WriteLine("long max = {0}", maxlong);
            Console.WriteLine("long min = {0}", minlong);
            Console.WriteLine("ulong max = {0}", maxulong);
            Console.WriteLine("ulong min = {0}", minulong);
        }
    }


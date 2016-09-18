/*  Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
    ©

   © ©

  ©   ©

 © © © ©
    Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

    Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it. */

using System;
using System.Text;


    class IsoscelesTriangle
    {
        static void Main()
        {
        char copyrightSymbol = '\u00A9';
        Console.OutputEncoding = Encoding.UTF8; //Makes possible to print out to console special symbols as ©
        Console.WriteLine("{0,5}\n\n{0,4}{0,2}\n\n{0,3}{0,4}\n\n{0,2}{0,2}{0,2}{0,2}", copyrightSymbol);
        }
    }


/*  A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console. */

using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Please input first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please input last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Please input age");
        byte age = Convert.ToByte(Console.ReadLine()); // read string from console and transfer it to different type of variables
        Console.WriteLine("Please input gender");
        char gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Please input Personal ID number");
        long idNumber = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Please input Unique employee number");
        uint employeeNumber = Convert.ToUInt32(Console.ReadLine());
        Console.Clear(); //clear console
        Console.WriteLine("Information for the employee:\nFirst Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique Employee Number: {5}", firstName, lastName, age, gender, idNumber, employeeNumber);
        }
    }


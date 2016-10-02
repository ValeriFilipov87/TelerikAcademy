/*  A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.
    program	                user
    Company name:	        Telerik Academy
    Company address:	    31 Al. Malinov, Sofia
    Phone number:	        +359 888 55 55 555
    Fax number:	
    Web site:	            http://telerikacademy.com/
    Manager first name:	    Nikolay
    Manager last name:	    Kostov
    Manager age:	        25
    Manager phone:	        +359 2 981 981*/

using System;


class PrPrintCompanyInformationogram
{
    static void Main()
    {
        Console.Write("Please input Company Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Please input Company Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please input Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Please input Fax Number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        Console.Write("Please input Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Please input Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please input Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Please input Manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Please input Manager phone: ");
        string managerPhone = Console.ReadLine();
        //print output
        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}",faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}


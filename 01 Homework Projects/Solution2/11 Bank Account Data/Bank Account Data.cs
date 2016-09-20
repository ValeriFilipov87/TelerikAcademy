/*  A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names. */

using System;

    class BankAccountData
    {
        static void Main()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your middle name:");
            string midlleName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter the available amount of money:");
            uint balance = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please enter bank name:");
            string bankName = Console.ReadLine();
            Console.WriteLine("Please enter IBAN:");
            string IBAN = Console.ReadLine();
            Console.WriteLine("Please enter your first credit card number:");
            uint credidCard1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second credit card number:");
            uint credidCard2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Please enter your third credit card number:");
            uint credidCard3 = Convert.ToUInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(@"
First Name: {0}
Middle Name: {1}
Last Name: {2}
Available Money: {3}
Bank Name: {4}
IBAN: {5}
First Credit Card: {6}
Second Credit Card: {7}
Third Credit Card: {8}", firstName, midlleName, lastName, balance, bankName, IBAN, credidCard1, credidCard2, credidCard3);

        }
    }


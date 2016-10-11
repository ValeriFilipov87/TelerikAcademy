/*  Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
 *  and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
 *  
    character	Valid card sign?
    5	        yes
    1	        no
    Q	        yes
    q	        no
    P	        no
    10	        yes
    500	        no 
*/



using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string colode = "2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A";
        Console.WriteLine("The values of cards are: {0}", colode);
        Console.Write("Please input values: ");
        string input = Console.ReadLine();

        char[] delimiters = new char[] { ' ', ',' };

        string[] stringColode = colode.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        string[] stringInput = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        string[] result = new string[input.Length];
        

        for (int i = 0; i < stringInput.Length; i++)
        {
            result[i] = Array.Find(stringColode, element => element.Equals(stringInput[i], StringComparison.Ordinal));
            if (result[i] != null)
            {
                Console.WriteLine("{0} - yes", result[i]);
            }
            else
            {
                Console.WriteLine("{0} - no", stringInput[i]);
            }
        }


    }
}


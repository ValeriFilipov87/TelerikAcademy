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

        string input = Console.ReadLine();

        char[] delimiters = new char[] { ' ', ',' };

        string[] checkInput = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        string[] checkColode = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        
        for (int i = 0; i < checkInput.Length; i++)
        {

            if (colode.Contains(checkInput[i]))
            {
                Console.WriteLine("{0} - Yes", checkInput[i]);
            }
            else
            {
                Console.WriteLine("{0} - No", checkInput[i]);
            }


        }


    }
}


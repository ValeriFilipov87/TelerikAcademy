using System;

class Exam4Task1CoffeeVendingMachine
{
    static void Main()
    {
        double valueFiveSt = 0.05;
        double valuesTenSt = 0.10;
        double valuesTwentySt = 0.20;
        double valuesFiftySt = 0.50;
        double valuesOneLv = 1.00;

        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        int N3 = int.Parse(Console.ReadLine());
        int N4 = int.Parse(Console.ReadLine());
        int N5 = int.Parse(Console.ReadLine());

        double inputMoney = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double machineMoney = valueFiveSt * N1 + valuesTenSt * N2 + valuesTwentySt * N3 + valuesFiftySt * N4 + valuesOneLv * N5;
        double change = new double();

        if (inputMoney >= price)
        {
            change = inputMoney - price;
            if (change <= machineMoney)
            {
                machineMoney -= change;
                Console.WriteLine("Yes {0:F2}", machineMoney);
            }
            else
            {
                Console.WriteLine("No {0:F2}", change  - machineMoney);
            }
        }
        else
        {
            Console.WriteLine("More {0:F2}", price - inputMoney);
        }

    }
}


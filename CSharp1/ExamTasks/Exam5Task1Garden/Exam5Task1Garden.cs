using System;

class Exam5Task1Garden
{
    static void Main()
    {
        int area = 250;
        double priceTomato = 0.5;
        double priceCucumber = 0.4;
        double pricePotato = 0.25;
        double priceCarrot = 0.6;
        double priceCabbage = 0.3;
        double priceBeans = 0.4;

        int seedsTomato = int.Parse(Console.ReadLine());
        int areaTomato = int.Parse(Console.ReadLine());
        int seedsCucumber = int.Parse(Console.ReadLine());
        int areaCucumber = int.Parse(Console.ReadLine());
        int seedsPotato = int.Parse(Console.ReadLine());
        int areaPotato = int.Parse(Console.ReadLine());
        int seedsCarrot = int.Parse(Console.ReadLine());
        int areaCarrot = int.Parse(Console.ReadLine());
        int seedsCabbage = int.Parse(Console.ReadLine());
        int areaCabbage = int.Parse(Console.ReadLine());
        int seedsBeans = int.Parse(Console.ReadLine());

        double result = new double();

        result = priceTomato * seedsTomato + priceCucumber * seedsCucumber + pricePotato * seedsPotato + priceCarrot * seedsCarrot + priceCabbage * seedsCabbage + priceBeans * seedsBeans;
        Console.WriteLine("Total costs: {0:F2}", result);

        int usedArea = areaTomato + areaCucumber + areaPotato + areaCarrot + areaCabbage;
        if (area - usedArea > 0)
        {
            Console.WriteLine("Beans area: {0}", area - usedArea);
        }
        if (area - usedArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        if (area - usedArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
    }
}


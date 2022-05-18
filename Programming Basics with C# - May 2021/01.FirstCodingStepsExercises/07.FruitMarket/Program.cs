using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double kgBananas = double.Parse(Console.ReadLine());
            double kgOrange = double.Parse(Console.ReadLine());
            double kgRaspberries = double.Parse(Console.ReadLine());
            double kgStrawberries = double.Parse(Console.ReadLine());

            double sumStrawberries = priceStrawberries * kgStrawberries;

            double priceRaspberries = priceStrawberries / 2;
            double sumRaspberries = kgRaspberries * priceRaspberries;

            double priceBananas = priceRaspberries - 0.80 * priceRaspberries;
            double sumBananas = kgBananas * priceBananas;

            double priceOranges = priceRaspberries - 0.40 * priceRaspberries;
            double sumOrange = kgOrange * priceOranges;

            double totalSum = sumBananas + sumOrange + sumRaspberries + sumStrawberries;

            Console.WriteLine($"{totalSum:F2}");

            
            
            
            
            
            
            


        }
    }
}

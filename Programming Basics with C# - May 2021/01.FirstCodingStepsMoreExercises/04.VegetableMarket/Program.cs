using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePricePerKg = double.Parse(Console.ReadLine());
            double fruitPricePerKg = double.Parse(Console.ReadLine());
            double vegetableTotalKg = double.Parse(Console.ReadLine());
            double fruitTotalKg = double.Parse(Console.ReadLine());

            double vegetableTotalPrice = vegetableTotalKg * vegetablePricePerKg;
            double fruiteTotalPrice = fruitTotalKg * fruitPricePerKg;

            double totalSum = (vegetableTotalPrice + fruiteTotalPrice) / 1.94;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}

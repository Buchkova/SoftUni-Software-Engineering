using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoli = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double totalSum = (magnoli * 3.25) + (zumbuli * 4) + (roses * 3.50) + (kaktusi * 8);
            double totalSumAfterTax = totalSum - (totalSum * 0.05);

            if (totalSum >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalSumAfterTax - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - totalSumAfterTax)} leva.");
            }
        }
    }
}

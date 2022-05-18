using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriyaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());

            double palamudPrice = skumriyaPrice + (skumriyaPrice * 0.60);
            double palamudTotalPrice = palamudPrice * palamudKg;

            double safridPrice = cacaPrice + (cacaPrice * 0.80);
            double safridTotalPrice = safridPrice * safridKg;

            double midiTotalprice = midiKg * 7.50;

            double totalSum = palamudTotalPrice + safridTotalPrice + midiTotalprice;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}

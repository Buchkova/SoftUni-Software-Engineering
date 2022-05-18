using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapePerKvM = double.Parse(Console.ReadLine());
            int litresWineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrape = vineyard * grapePerKvM;
            double grapeForWine = totalGrape * 0.4;
            double litresWine = grapeForWine / 2.5;
            

            if (litresWine >= litresWineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litresWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litresWine - litresWineNeeded)} liters left -> {Math.Ceiling((litresWine - litresWineNeeded) / workers)} liters per person.");
            }
            else if (litresWine < litresWineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litresWineNeeded - litresWine)} liters wine needed.");
            }
        }
    }
}

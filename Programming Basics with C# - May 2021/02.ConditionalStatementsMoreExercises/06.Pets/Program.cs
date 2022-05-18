using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double dogFoodKgPerDay = double.Parse(Console.ReadLine());
            double catFoodKgPerDay = double.Parse(Console.ReadLine());
            double turtuleFoodGramsPerDay = double.Parse(Console.ReadLine());

            double dogFood = days * dogFoodKgPerDay;
            double catFood = days * catFoodKgPerDay;
            double turtuleFood = (days * turtuleFoodGramsPerDay) / 1000;

            double totalFood = dogFood + catFood + turtuleFood;

            if (totalFood <= kgFood)
            {
                Console.WriteLine($"{Math.Floor(kgFood - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - kgFood)} more kilos of food are needed.");
            }
        }
    }
}

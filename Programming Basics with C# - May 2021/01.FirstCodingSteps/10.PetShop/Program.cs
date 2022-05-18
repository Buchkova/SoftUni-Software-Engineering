using System;

namespace _10.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogCount = int.Parse(Console.ReadLine());
            int otherAnimalsCount = int.Parse(Console.ReadLine());

            double totalDogsFoodPrice = dogCount * 2.5;
            double totalOthreAnimalsFoodPrice = otherAnimalsCount * 4.0;

            double totalFoodPrice = totalDogsFoodPrice + totalOthreAnimalsFoodPrice;

            Console.WriteLine($"{totalFoodPrice} lv.");



        }
    }
}

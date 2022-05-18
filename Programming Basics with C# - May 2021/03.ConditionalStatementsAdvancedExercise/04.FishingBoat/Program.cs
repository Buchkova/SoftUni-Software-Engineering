using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double shipPrice = 0;

            switch (season)
            {
                case "Spring":
                    shipPrice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    shipPrice = 4200;
                    break;
                case "Winter":
                    shipPrice = 2600;
                    break;
            }

            if (fishermans <= 6)
            {
                shipPrice -= shipPrice * 0.10;
            }
            else if (fishermans <= 11)
            {
                shipPrice -= shipPrice * 0.15;
            }
            else if (fishermans >= 12)
            {
                shipPrice -= shipPrice * 0.25;
            }

            if (fishermans % 2 == 0 && season != "Autumn")
            {
                shipPrice -= shipPrice * 0.05;
            }

            if (budget >= shipPrice)
            {
                Console.WriteLine($"Yes! You have {budget - shipPrice:f2} leva left.");
            }
            else if (budget < shipPrice)
            {
                Console.WriteLine($"Not enough money! You need {shipPrice - budget:f2} leva.");
            }
        }
    }
}

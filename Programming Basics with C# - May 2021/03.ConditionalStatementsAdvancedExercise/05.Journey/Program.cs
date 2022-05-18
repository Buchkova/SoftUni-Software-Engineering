using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //summer & winter
            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета
            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета
            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            string destination = string.Empty;
            double totalCost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    totalCost = 0.30 * budget;
                }
                else if (season == "winter")
                {
                    totalCost = 0.70 * budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    totalCost = 0.40 * budget;
                }
                else if (season == "winter")
                {
                    totalCost = 0.80 * budget;
                }
            }
            else
            {
                destination = "Europe";
                totalCost = 0.90 * budget;    
            }
            
            Console.WriteLine($"Somewhere in {destination}");
            
            if (season == "summer" && destination != "Europe")
            {
                Console.WriteLine($"Camp - {totalCost:F2}");
            }
            else
            {
                Console.WriteLine($"Hotel - {totalCost:F2}");
            }
            
            
        }
    }
}

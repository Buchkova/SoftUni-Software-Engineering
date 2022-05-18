using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double pricePerFlower = 0;
            double discount = 0;

            switch (flowers)
            {
                case "Roses":
                    pricePerFlower = 5;
                    
                    if (numOfFlowers > 80)
                    {
                        discount = 0.90;
                    }
                    break;
                case "Dahlias":
                    pricePerFlower = 3.80;

                    if ( numOfFlowers > 90)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Tulips":
                    pricePerFlower = 2.80;

                    if (numOfFlowers > 80)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Narcissus":
                    pricePerFlower = 3;

                    if (numOfFlowers < 120)
                    {
                        discount = 1.15;
                    }
                        break;
                case "Gladiolus":
                    pricePerFlower = 2.50;

                    if (numOfFlowers < 80)
                    {
                        discount = 1.20;
                    }
                    break;
            }
                
            double totalPrice = pricePerFlower * numOfFlowers;

            if (discount > 0)
            {
                totalPrice = totalPrice * discount;
            }
            if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {flowers} and {budget - totalPrice:F2} leva left.");    
            }
        }
    }
}


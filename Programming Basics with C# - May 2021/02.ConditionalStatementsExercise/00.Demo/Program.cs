using System;

namespace _00.Demo
    {
        class Program
        {
            static void Main(string[] args)
            {

                double budget = double.Parse(Console.ReadLine());
                int statists = int.Parse(Console.ReadLine());
                double clothingPerStatist = double.Parse(Console.ReadLine());

                double totalClothingPrice = statists * clothingPerStatist;
                double decorPrice = (budget * 0.1);

                if (statists >= 150)
                {
                    totalClothingPrice = totalClothingPrice - (totalClothingPrice * 0.1);
                }

                double totalExpenses = totalClothingPrice + decorPrice;
                double moneyNeeded = Math.Abs(budget - totalExpenses);

                if (totalExpenses > budget)
                {
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
                }

                if (totalExpenses <= budget)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyNeeded:F2} leva left.");
                }
            }
        }
    }

  

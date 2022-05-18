using System;

namespace _05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {totalSum:F2}");
                    break;
                }

                double deposit = double.Parse(input);

                if (deposit >= 0)
                {
                    Console.WriteLine($"Increase: {deposit:F2}");
                    totalSum += deposit;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {totalSum:F2}");
                    break;
                }
            }

            
        }
    }
}

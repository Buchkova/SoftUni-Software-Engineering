using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());

            int spendDaysCounter = 0;
            int daysCounter = 0;

            while (savedMoney < moneyNeeded)
            {
                string action = Console.ReadLine(); //spend/save
                double amount = double.Parse(Console.ReadLine());

                daysCounter++;

                if (action == "spend")
                {
                    spendDaysCounter++;
                    savedMoney -= amount;

                    if (savedMoney < 0)
                    {
                        savedMoney =0;
                    }
                }
                else if (action == "save")
                {
                    spendDaysCounter = 0;
                    savedMoney += amount;
                }

                if (spendDaysCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{daysCounter}");
                    break;
                }
            }

            if (savedMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}

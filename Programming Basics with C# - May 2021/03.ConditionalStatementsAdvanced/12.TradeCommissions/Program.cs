using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Град    0 ≤ s ≤ 500    500 < s ≤ 1 000       1 000 < s ≤ 10 000        s > 10 000
            //Sofia   5 %                   7 %                     8 %                  12 %
            //Varna   4.5 %                 7.5 %                   10 %                 13 %
            //Plovdiv 5.5 %                 8 %                     12 %                 14.5 %

            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0;

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08;
                }
                else if (sales > 10000)
                {
                    commission = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.10;
                }
                else if (sales > 10000)
                {
                    commission = 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else if (sales > 10000)
                {
                    commission = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            double totalSum = sales * commission;

            if (commission > 0)
            {
                Console.WriteLine($"{totalSum:F2}");
            }
        }
    }
}

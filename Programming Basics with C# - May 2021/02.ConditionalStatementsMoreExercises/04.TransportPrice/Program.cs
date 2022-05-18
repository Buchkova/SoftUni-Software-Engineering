using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double startPrice = 0;
            double price = 0;

            if (time == "day")
            {
                if (km < 20)
                {
                    startPrice = 0.70;
                    price = 0.79;
                }
                else if (km >= 100)
                {
                    price = 0.06;
                }
                else if (km >= 20)
                {
                    price = 0.09;
                }
                

            }
            else if (time == "night")
            {
                if (km < 20)
                {
                    startPrice = 0.70;
                    price = 0.90;
                }
                else if (km >= 100)
                {
                    price = 0.06;
                }
                else if (km >= 20)
                {
                    price = 0.09;
                }
                
            }

            if (km < 20)
            {
                Console.WriteLine($"{startPrice + (km * price):f2}");
            }
            else
            {
                Console.WriteLine($"{(km * price):f2}");
            }
        }
    }
}

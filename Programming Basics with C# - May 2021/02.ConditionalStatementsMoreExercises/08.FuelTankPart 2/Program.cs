using System;

namespace _08.FuelTankPart_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litres = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double price = 0;

            if (card == "Yes")
            {
                if (fuelType == "Gasoline")
                {
                    price = (litres * 2.22) - (0.18 * litres);
                }
                else if (fuelType == "Diesel")
                {
                    price = litres * 2.33 - (0.12 * litres);
                }
                else if (fuelType == "Gas")
                {
                    price = litres * 0.93 - (0.08 * litres);
                }
            }
            else if (card == "No")
            {
                if (fuelType == "Gasoline")
                {
                    price = litres * 2.22;
                }
                else if (fuelType == "Diesel")
                {
                    price = litres * 2.33;
                }
                else if (fuelType == "Gas")
                {
                    price = litres * 0.93;
                }
            }

            if (litres >= 20 && litres <= 25)
            {
                price -= price * 0.08;
            }
            else if (litres > 25)
            {
                price -= price * 0.10;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}

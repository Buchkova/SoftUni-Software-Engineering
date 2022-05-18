using System;

namespace _01._2Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rolls = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int seats = rolls * cols;
            double price = 0;
            switch (type)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5;
                    break;

            }
            double result = seats * price;
            Console.WriteLine($"{result:F2} leva");
        }
    }
}

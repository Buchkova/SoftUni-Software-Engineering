using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rolls = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int seats = rolls * cols;

            switch (type)
            {
                case "Premiere":
                    Console.WriteLine($"{seats * 12:F2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{seats * 7.50:F2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{seats * 5:F2} leva");
                    break;

            }

        }

    }
}

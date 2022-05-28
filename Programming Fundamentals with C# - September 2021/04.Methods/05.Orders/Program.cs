using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            printingPrice(product, quantity);

        }

        private static void printingPrice(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                        price = quantity * 1.50;
                    break;
                case "water":
                    price = quantity * 1.00;
                    break;
                case "coke":
                    price = quantity * 1.40;
                    break;
                case "snacks":
                    price = quantity * 2.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{(price):f2}"); 
        }
    }
}

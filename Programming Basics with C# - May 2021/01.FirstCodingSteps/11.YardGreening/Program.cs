using System;

namespace _11.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardSqMeeters = double.Parse(Console.ReadLine());
            double pricePerYard = 7.61;
            double discount = 0.18;

            double totalYardprice = yardSqMeeters * pricePerYard;
            double totalDiscount = totalYardprice * discount;
            double endPrice = totalYardprice - totalDiscount;


            Console.WriteLine($"The final price is: {endPrice} lv.");
            Console.WriteLine($"The discount is: {totalDiscount} lv.");

        }
    }
}

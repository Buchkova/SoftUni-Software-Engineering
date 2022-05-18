using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string raiting = Console.ReadLine();
            int nightStayed = days - 1;

            double finalPayment = 0;

            if (roomType == "room for one person")
            {
                finalPayment = nightStayed * 18.0;
            }
            else if (roomType == "apartment")
            {
                if (days < 10)
                {
                    double priceWithoutDiscount = nightStayed * 25.0;
                    double discount = priceWithoutDiscount * 0.30;
                    finalPayment = priceWithoutDiscount - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    double priceWithoutDiscount = nightStayed * 25.0;
                    double discount = priceWithoutDiscount * 0.35;
                    finalPayment = priceWithoutDiscount - discount;
                }
                else if (days > 15)
                {
                    double priceWithoutDiscount = nightStayed * 25.0;
                    double discount = priceWithoutDiscount * 0.50;
                    finalPayment = priceWithoutDiscount - discount;
                }
            }
            else if (roomType == "president apartment")
            {
                if (days < 10)
                {
                    double priceWithoutDiscount = nightStayed * 35.0;
                    double discount = priceWithoutDiscount * 0.10;
                    finalPayment = priceWithoutDiscount - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    double priceWithoutDiscount = nightStayed * 35.0;
                    double discount = priceWithoutDiscount * 0.15;
                    finalPayment = priceWithoutDiscount - discount;
                }
                else if (days > 15)
                {
                    double priceWithoutDiscount = nightStayed * 35.0;
                    double discount = priceWithoutDiscount * 0.20;
                    finalPayment = priceWithoutDiscount - discount;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            //calculates tip
            if (raiting == "positive")
            {
                double tip = finalPayment * 0.25;
                finalPayment = finalPayment + tip;
            }
            else if (raiting == "negative")
            {
                double tip = finalPayment * 0.10;
                finalPayment = finalPayment - tip;
            }

            Console.WriteLine($"{finalPayment:F2}");
        }
    }
}

using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numOfNights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            if (month == "May" || month == "October")
            {
                apartmentPrice = 65;
                studioPrice = 50;

                if (numOfNights > 7 && numOfNights < 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                if (numOfNights > 14)
                {
                    studioPrice -= studioPrice * 0.30;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
                
            }
            else if (month == "June" || month == "September")
            {
                apartmentPrice = 68.70;
                studioPrice = 75.20;

                if (numOfNights > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
                
            }
            else if (month == "July" || month == "August")
            {
                apartmentPrice = 77;
                studioPrice = 76;
                
                if (numOfNights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }

            double apartmentTotalPrice = numOfNights * apartmentPrice;
            double studioTotalPrice = numOfNights * studioPrice;

            Console.WriteLine($"Apartment: {apartmentTotalPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioTotalPrice:f2} lv.");

        }
    }
}

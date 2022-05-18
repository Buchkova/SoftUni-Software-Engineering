using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read the intput

            //1.Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]

            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //2. calculate the total price of the order
            
            //•	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.

            double totalPrice = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            //3. discount - Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена

            int numberOfToys = puzzles + dolls + bears + minions + trucks;

            if (numberOfToys >= 50)
            {
                totalPrice = totalPrice - 0.25 * totalPrice;
                //totalPrice -= 0.25 * totalPrice; same thing " -= " означава да се извади от тотал прайс 0,25 * тотал прайс
                //totalPrice = totalPrice * 0.75;
            }

            //4. От спечелените пари Петя трябва да даде 10% за наема на магазина

            totalPrice -= totalPrice * 0.10;

            //5. Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
            //bool toys = totalToys >= 50;

            if (totalPrice >= holidayPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - holidayPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - totalPrice:F2} lv needed.");
            }

        }
    }
}

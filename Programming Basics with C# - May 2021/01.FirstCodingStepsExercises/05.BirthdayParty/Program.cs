using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallPrice = double.Parse(Console.ReadLine());
            double cakePrice = hallPrice * 0.20;
            double drinksPrice = cakePrice - 0.45 * cakePrice; //cakePrice * (1-0.45) . cakePrice * 0.55
            double animatorPrice = hallPrice / 3; 
            double sum = hallPrice + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(sum);
        }
    }
}

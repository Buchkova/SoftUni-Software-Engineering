using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafels = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double totalCakePrice = cakes * 45.0;
            double totalWafelsPrice = wafels * 5.80;
            double totalPancakesPrice = pancakes * 3.20;

            double sumForDay = (totalCakePrice + totalWafelsPrice + totalPancakesPrice) * cookers;
            double totalCharitySum = sumForDay * days;
            double sumAfterCosts = totalCharitySum - (totalCharitySum / 8);

           
            Console.WriteLine(sumAfterCosts);


        }
    }
}

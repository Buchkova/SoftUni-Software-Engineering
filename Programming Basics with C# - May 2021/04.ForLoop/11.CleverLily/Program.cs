using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            int toyCounter = 0;
            double savedMoney = 0;


            for (int birthdayNumber = 1; birthdayNumber <= lilysAge; birthdayNumber++)
            {
                if (birthdayNumber % 2 == 0)
                {
                    savedMoney += ((birthdayNumber / 2) * 10) - 1;
                }
                else
                {
                    toyCounter++;
                }
            }
            double totalSaved = savedMoney + (toyCounter * toyPrice);

            if (totalSaved >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {totalSaved - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - totalSaved:f2}");
            }
        }
    }
}

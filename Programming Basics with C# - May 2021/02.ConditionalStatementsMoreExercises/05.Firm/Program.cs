using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overTimeWorkers = int.Parse(Console.ReadLine());

            double workingDays = days - (days * 0.10);
            double hoursWorked = workingDays * 8;
            double overTime = 2 * days * overTimeWorkers;
            double totalHours = Math.Floor(hoursWorked + overTime);

            if (totalHours <= givenHours)
            {
                Console.WriteLine($"Not enough time!{(givenHours - totalHours)} hours needed."); 
            }
            else
            {
                Console.WriteLine($"Yes!{totalHours - givenHours} hours left.");
            }

            //има бъг
        }
    }
}

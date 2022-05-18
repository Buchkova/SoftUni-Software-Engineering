using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            
            if (dayOfTheWeek == "Monday"
                || dayOfTheWeek == "Tuesday"
                || dayOfTheWeek == "Wednesday"
                || dayOfTheWeek == "Thursday"
                || dayOfTheWeek == "Friday"
                || dayOfTheWeek == "Saturday")
            {
                if (time >=10 && time <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }

            
            }
            else if (dayOfTheWeek == "Sunday")
            {
                Console.WriteLine("closed");
            }
        }
    }
}

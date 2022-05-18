using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int workingDays = 365 - daysOff;
            int totalPlay = (workingDays * 63) + (daysOff * 127);
            int diffrerence = 30000 - totalPlay;

            int hours = Math.Abs(diffrerence / 60);
            int minutes = Math.Abs(diffrerence  % 60);

            if (totalPlay <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }


        }
    }
}

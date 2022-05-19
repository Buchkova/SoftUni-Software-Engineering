using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 30;

            if (min >= 60)
            {
                hour += 1;
                min -= 60;

                if (hour >= 24)
                {
                    hour = 0;
                }
            }

            Console.WriteLine($"{hour}:{min:D2}");

            
            

        }
    }
}

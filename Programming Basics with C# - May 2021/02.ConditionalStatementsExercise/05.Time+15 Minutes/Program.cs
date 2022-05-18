using System;

namespace _05.Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hour * 60 + minutes;

            int totalMinutes2 = totalMinutes + 15;

            int hour2 = (totalMinutes2 / 60) % 24;
            int minutes2 = totalMinutes2 % 60;

            Console.WriteLine($"{hour2}:{minutes2:D2}");
        }
    }
}

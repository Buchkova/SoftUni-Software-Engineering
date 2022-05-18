using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. read input
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double worldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            // 2. calculate Ivan's time

            double totalTime = meters * timePerMeter;
            double delay = Math.Floor(meters / 15) * 12.5;
            totalTime += delay;
            // 3. check ehether Ivan bit the world record
            if (totalTime < worldRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:F2} seconds slower.");
            }
        }
    }
}

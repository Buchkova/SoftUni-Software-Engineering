using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double tankVolume = lenght * width * height;
            double totalLiters = tankVolume * 0.001;
            double totalLitersNeeded = totalLiters * (1 - percent / 100);
            

            Console.WriteLine(totalLitersNeeded);

        }
    }
}

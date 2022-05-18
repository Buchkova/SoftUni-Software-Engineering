using System;

namespace _01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double v = double.Parse(Console.ReadLine());
            double p1 = double.Parse(Console.ReadLine());
            double p2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double totalLitres = (p1 + p2) * h;

            if (totalLitres <= v)
            {
                Console.WriteLine($"The pool is {totalLitres / v * 100:f2}% full. Pipe 1: {(p1 * h) / totalLitres * 100:f2}%. Pipe 2: {(p2 * h) / totalLitres * 100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {h:f2} hours the pool overflows with {totalLitres - v:f2} liters.");
            }

        }
    }
}

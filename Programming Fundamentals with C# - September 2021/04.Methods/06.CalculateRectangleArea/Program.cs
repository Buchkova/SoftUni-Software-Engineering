using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            printRectangleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        private static void printRectangleArea(int width, int length)
        {
            Console.WriteLine(width * length);
        }
    }
}

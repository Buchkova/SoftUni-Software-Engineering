using System;

namespace _04.PrintingTriangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        private static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                printTriangleLine(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                printTriangleLine(i);
            }
 
        }

        private static void printTriangleLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}

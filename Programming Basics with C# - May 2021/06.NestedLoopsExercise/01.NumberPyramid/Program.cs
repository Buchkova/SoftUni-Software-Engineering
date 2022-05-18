using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
               
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        return;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
            }
        }
    }
}

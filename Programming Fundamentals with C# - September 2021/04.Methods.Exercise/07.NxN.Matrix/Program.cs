using System;

namespace _07.NxN.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            printsMatrixs(n);
        }

        private static void printsMatrixs(int n)
        {
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

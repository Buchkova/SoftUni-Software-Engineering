using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());

            printResult(x,sign,y);
        }

        private static void printResult(int x, string sign, int y)
        {
            if (sign =="+")
            {
                Console.WriteLine(x + y);
            }
            else if (sign == "-")
            {
                Console.WriteLine(x - y);
            }
            else if (sign == "*")
            {
                Console.WriteLine(x * y);
            }
            else if (sign == "/")
            {
                Console.WriteLine(x / y);
            }

        }
        
    }
}

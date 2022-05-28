using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            if (command == "add")
            {
                add(a,b);
            }
            else if (command == "multiply")
            {
                multiply(a,b);
            }
            else if (command == "subtract")
            {
                subract(a,b);
            }
            else if (command == "divide")
            {
                divide(a,b);
            }

            
        }

        private static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        private static void subract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        private static void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}

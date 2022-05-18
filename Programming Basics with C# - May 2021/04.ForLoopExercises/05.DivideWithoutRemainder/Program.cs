using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double firstRange = 0;
            double secondRange = 0;
            double thirdRange = 0;
            

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    firstRange++;
                }
                if (number % 3 == 0)
                {
                    secondRange++;
                }
                if (number % 4 == 0)
                {
                    thirdRange++;
                }
                
            }
            double p1 = firstRange / n * 100;
            double p2 = secondRange / n * 100;
            double p3 = thirdRange / n * 100;
            

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            

        }
    }
}

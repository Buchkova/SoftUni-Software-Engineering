using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            GetMultipleOfEvenAndOdds(number);
        }

        private static void GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= number; i++)
            {
                
                if (number % 10 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
                number /= 10;
            }
            Console.WriteLine(evenSum);
            Console.WriteLine(oddSum);
        }
    }
}

using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temNum = number;
            int factorialSum = 0;

            while (temNum > 0)
            {
                int currNumber = temNum % 10;
                temNum /= 10;
                int currFactNum = 1;
                for (int i = 1; i <= currNumber; i++)
                {
                    currFactNum *= i;
                }
                factorialSum += currFactNum;
            }

            string result = factorialSum == number ? "yes" : "no";
            Console.WriteLine(result);
        }
    }
}

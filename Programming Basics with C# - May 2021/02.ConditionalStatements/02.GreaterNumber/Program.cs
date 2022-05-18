using System;

namespace _02.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            // double biggerNumber = Math.Max(num1 , num2);
            // Console.WriteLine(biggerNumber)

            bool isFirstNumberBigger = num1 > num2;

            if (isFirstNumberBigger)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}

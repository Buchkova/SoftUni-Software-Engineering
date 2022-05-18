using System;

namespace _03.EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            //double reminderFromDevision = number % 2;
            //bool isEven = reminderFromDevision == 0;


            bool isEven = (number % 2) == 0;

            if (isEven)
            {
                Console.WriteLine("even");
            }
            else
            {

                Console.WriteLine("odd");
            
            }
        }
    }
}

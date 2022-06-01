using System;

namespace _01.BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int count = 0;
            
            while (number != 0)
            {
                int leftover = number % 2;
                if (leftover == digit)
                {
                    count++;
                }
                number = number / 2;
                
            }
            Console.WriteLine(count);
        }
    }
}

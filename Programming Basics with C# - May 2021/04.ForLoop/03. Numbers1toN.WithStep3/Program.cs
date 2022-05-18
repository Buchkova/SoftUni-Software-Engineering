using System;

namespace _03._Numbers1toN.WithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int number = 1; number <= endNum; number += 3)
            {
                Console.WriteLine(number);
            }
        }
    }
}

using System;

namespace _02.Numbers_N1
{
    class Program
    {
        static void Main(string[] args)
        {

            int startingNum = int.Parse(Console.ReadLine());

            for (int number = startingNum; number >= 1; number -= 1)
            {
                Console.WriteLine(number);
            }
        }
    }
}

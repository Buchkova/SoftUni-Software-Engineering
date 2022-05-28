    using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(printSmallestNumber(x, y, z));
        }

        static int printSmallestNumber(int x, int y, int z)
        {
            if (x < y)
            {
                return x < z ? x : z;
            }
            return y < z ? y : z;
        }
    }
}

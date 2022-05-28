using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            sumFirstTwoIntegers(x, y);
            Console.WriteLine(subtractsThirdInteger(x, y, z));
        } 

        private static int subtractsThirdInteger(int x, int y, int z)
        {
            return sumFirstTwoIntegers(x,y)-z;
        }

        private static int sumFirstTwoIntegers(int x, int y)
        {
            return x + y;
        }
    }
}

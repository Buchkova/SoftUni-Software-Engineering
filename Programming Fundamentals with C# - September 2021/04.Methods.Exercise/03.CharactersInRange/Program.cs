using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            printRange(start, end);
        }

        private static void printRange(char start, char end)
        {

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
            if (end < start)
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}

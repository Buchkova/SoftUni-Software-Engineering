using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            repeatString(Console.ReadLine(), int.Parse(Console.ReadLine()));

        }

        private static void repeatString(string text, int repeats)
        {
            for (int i = 1; i <= repeats; i++)
            {
                Console.Write(text);
            }
        }
    }
}

using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            printsMiddleCharacter(text);
        }

        private static void printsMiddleCharacter(string text)
        {
            if (text.Length % 2 != 0)
            {
                Console.WriteLine(text[text.Length / 2]);
            }
            else
            {
                Console.Write(text[(text.Length / 2) - 1]);
                Console.Write(text[text.Length / 2]);
            }
            Console.WriteLine();
        }
    }
}

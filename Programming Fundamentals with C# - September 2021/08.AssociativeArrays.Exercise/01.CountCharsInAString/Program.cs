using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToCharArray();
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var letter in words)
            {
                if (letter != ' ')
                {
                    if (!letters.ContainsKey(letter))
                    {
                        letters.Add(letter, 0);
                    }
                    
                    letters[letter]++;
                }
            }

            foreach (var word in letters)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}

﻿using System;

namespace _02.Vowels.Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            printVowels(text);
        }

        private static void printVowels(string text)
        {
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    sum++;

                }

            }
            Console.WriteLine(sum);
        }
    }
}

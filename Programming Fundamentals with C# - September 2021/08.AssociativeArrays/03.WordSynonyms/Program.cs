﻿using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonymWords = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonymWords.ContainsKey(word))
                {
                    synonymWords[word] = new List<string>();
                }
                synonymWords[word].Add(synonym);
            }
            foreach (var word in synonymWords)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
            
        }
    }
}

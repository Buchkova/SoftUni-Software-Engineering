﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace _05.CitiesByContinentAndCountry
{
    class Program
    {

        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> register = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!register.ContainsKey(continent))
                {
                    register.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!register[continent].ContainsKey(country))
                {
                    register[continent].Add(country, new List<string>());
                }
                register[continent][country].Add(city);
            }

            foreach (var currentContinent in register)
            {
                Console.WriteLine($"{currentContinent.Key}:");

                foreach (var currentCountry in currentContinent.Value)
                {
                    Console.WriteLine($"  {currentCountry.Key} -> {string.Join(", ", currentCountry.Value)}");
                }
            }
        }
    }
}
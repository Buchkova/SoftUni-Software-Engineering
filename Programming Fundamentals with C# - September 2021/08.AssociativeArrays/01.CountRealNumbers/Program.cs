using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> conuts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (conuts.ContainsKey(number))
                {
                    conuts[number]++;
                }
                else
                {
                    conuts.Add(number, 1);
                }
            }

            foreach (var count in conuts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
            

        }
    }
}

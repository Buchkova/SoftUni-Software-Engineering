using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            var bomb = bombAndPower[0];
            var power = bombAndPower[1];
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int startIndex = i - power;
                    if (i - power < 0)
                    {
                        startIndex = 0;
                    }

                    int finishIndex = power + i;
                    if (power + i > numbers.Count - 1)
                    {
                        finishIndex = numbers.Count - 1;
                    }
                    for (int j = startIndex; j <= finishIndex; j++)
                    {
                        numbers[j] = 0;
                    }

                }

            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            
        }
    }
}

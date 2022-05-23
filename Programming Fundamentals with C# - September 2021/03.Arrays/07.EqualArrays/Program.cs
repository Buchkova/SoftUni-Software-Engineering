using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numbers1.Length; i++)
            {
                int number = numbers1[i];
                if (numbers1[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }

            for (int j = 0; j < numbers1.Length; j++)
            {
                int number = numbers1[j];

                if (numbers1[j] == numbers2[j])
                {
                    sum += number;  
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}

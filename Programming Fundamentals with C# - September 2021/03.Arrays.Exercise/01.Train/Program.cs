using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}

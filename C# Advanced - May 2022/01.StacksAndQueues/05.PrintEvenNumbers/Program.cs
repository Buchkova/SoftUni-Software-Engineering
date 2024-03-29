﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    numbers.Enqueue(input[i]);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
//Create a program that:
//•	Reads an array of integers and adds them to a queue.
//•	Prints the even numbers separated by ", ".


﻿using System;

namespace _03.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());

            double F = C * 1.8 + 32;
            Console.WriteLine($"{F:F2}");
        }
    }
}

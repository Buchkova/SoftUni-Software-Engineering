﻿using System;

namespace _01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int hour = 0; hour <= 23; hour++)
            //{
            //    for (int minutes = 0; minutes <= 59; minutes++)
            //    {
            //        Console.WriteLine($"{hour:D2}:{minutes:D2}");
            //    }
            //}

            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hour}:{minutes}");
                }
            }
        }
    }
}
﻿using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0;
            //int takova = 0;
            //bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine("{0} -> {1}", takova, toe);
            //    obshto = 0;
            //    ch = takova;
            //}

            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                bool isSpecial = false;

                if (sum == 7 || sum == 5 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");

            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);

            while (kids.Count > 1)
            {
                for (int i = 1; i < number; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
            

        }
    }
}
//Create a program that simulates the game of Hot Potato. Print every kid that is removed from the circle. In the end, print the kid that is left last.

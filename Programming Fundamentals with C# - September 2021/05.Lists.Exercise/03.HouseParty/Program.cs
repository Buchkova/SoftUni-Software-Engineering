using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommand = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numOfCommand; i++)
            {
                 
                string commmand = Console.ReadLine();
                var currCommand = commmand.Split();
                if (!guests.Contains(currCommand[0]) && currCommand.Length == 3)
                {
                    guests.Add(currCommand[0]);
                }
                else if (guests.Contains(currCommand[0]) && currCommand.Length == 3)
                {
                    Console.WriteLine($"{currCommand[0]} is already in the list!");
                }
                if (guests.Contains(currCommand[0]) && currCommand[2] == "not")
                {
                    guests.Remove(currCommand[0]);
                }
                else if (!guests.Contains(currCommand[0]) && currCommand[2] == "not")
                {
                    Console.WriteLine($"{currCommand[0]} is not in the list!");
                }

            }

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

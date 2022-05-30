using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capasity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currCommand = command.Split();
                if (currCommand[0] == "Add")
                {
                    int passengerToAdd = int.Parse(currCommand[1]);
                    wagons.Add(passengerToAdd);
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passengers = int.Parse(currCommand[0]);
                        if ((wagons[i] + passengers) <= capasity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));


        }
    }
}

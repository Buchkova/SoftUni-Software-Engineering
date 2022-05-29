using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            
            while (command != "end")
            {
                var currCommand = command.Split();

                if (currCommand[0] == "Add")
                {
                    int numberToAdd = int.Parse(currCommand[1]);
                    numbers.Add(numberToAdd);
                }
                else if (currCommand[0] == "Remove")
                {
                    int numberToRemove = int.Parse(currCommand[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (currCommand[0] == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(currCommand[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                }
                else if (currCommand[0] == "Insert")
                {
                    int numberToInsert = int.Parse(currCommand[1]);
                    int position = int.Parse(currCommand[2]);
                    numbers.Insert(position, numberToInsert);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

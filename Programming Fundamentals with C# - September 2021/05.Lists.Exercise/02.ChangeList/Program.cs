using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
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
                if (currCommand[0] == "Delete")
                {
                    int numToRemove = int.Parse(currCommand[1]);
                    numbers.RemoveAll(x => x == numToRemove);
                }
                else if (currCommand[0] == "Insert")
                {
                    int element = int.Parse(currCommand[1]);
                    int position = int.Parse(currCommand[2]);
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

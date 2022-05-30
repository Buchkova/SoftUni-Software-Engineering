using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                var currCommand = command.Split();
                if (currCommand[0] == "Add")
                {
                    int numberToAdd = int.Parse(currCommand[1]);
                    numbers.Add(numberToAdd);
                }
                else if (currCommand[0] == "Insert")
                {
                    int numberToInsert = int.Parse(currCommand[1]);
                    int index = int.Parse(currCommand[2]);
                    if (index >= 0 && index <= numbers.Count)
                    {
                        numbers.Insert(index, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }

                }
                else if (currCommand[0] == "Remove")
                {
                    int RemoveFromIndex = int.Parse(currCommand[1]);
                    if (RemoveFromIndex >= 0 && RemoveFromIndex <= numbers.Count)
                    {
                        numbers.RemoveAt(RemoveFromIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if (currCommand[0] == "Shift" && currCommand[1] == "left")
                {
                    ShiftLeft(numbers, int.Parse(currCommand[2]));

                }
                else if (currCommand[0] == "Shift" && currCommand[1] == "right")
                {
                    ShiftRight(numbers, int.Parse(currCommand[2]));
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));

        }

        private static void ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

        private static void ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._ListManipulationAdvanced
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
                else if (currCommand[0] == "Contains")
                {
                    int containedNumber = int.Parse(currCommand[1]);
                    if (numbers.Contains(containedNumber))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (currCommand[0] == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        
                    }
                    Console.WriteLine();
                }
                else if (currCommand[0] == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            Console.Write($"{numbers[i]} ");
                        }           
                    }
                    Console.WriteLine();
                }
                else if (currCommand[0] == "GetSum")
                {   
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (currCommand[0] == "Filter" && currCommand[1] == "<")
                {
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < num)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        
                    }
                    Console.WriteLine();
                }
                else if (currCommand[0] == "Filter" && currCommand[1] == ">")
                {
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > num)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        
                    }
                    Console.WriteLine();
                }
                else if (currCommand[0] == "Filter" && currCommand[1] == "<=")
                {
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= num)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        
                    }
                    Console.WriteLine();
                }
                else if (currCommand[0] == "Filter" && currCommand[1] == ">=")
                {
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= num)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        
                    }
                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }
    }
}

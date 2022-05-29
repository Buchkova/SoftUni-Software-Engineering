using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;
            string command = Console.ReadLine();

            while (command != "end")
            {
                var currCommand = command.Split();
                if (currCommand[0] == "Add")
                {
                    int numberToAdd = int.Parse(currCommand[1]);
                    numbers.Add(numberToAdd);
                    isChanged = true;
                   
                }
                else if (currCommand[0] == "Remove")
                {
                    int numberToRemove = int.Parse(currCommand[1]);
                    numbers.Remove(numberToRemove);
                    isChanged = true;
                    
                }
                else if (currCommand[0] == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(currCommand[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                    isChanged = true;
                    
                }
                else if (currCommand[0] == "Insert")
                {
                    int numberToInsert = int.Parse(currCommand[1]);
                    int position = int.Parse(currCommand[2]);
                    numbers.Insert(position, numberToInsert);
                    isChanged = true;
                    
                }
                else if (currCommand[0] == "Contains")
                {
                    int number = int.Parse(currCommand[1]);
                    if (numbers.Contains(number))
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
                    List<int> even = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            even.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", even));
                    
                }
                else if (currCommand[0] == "PrintOdd")
                {
                    List<int> odd = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            odd.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", odd));
                    
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
                else if (currCommand[0] == "Filter" && currCommand[1] == ">")
                {
                    List<int> filtered = new List<int>();
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > num)
                        {
                            filtered.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", filtered));
                    
                }
                else if (currCommand[0] == "Filter" && currCommand[1] == "<")
                {
                    List<int> filtered = new List<int>();
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < num)
                        {
                            filtered.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", filtered));
                    
                }
                else if (currCommand[0] == "Filter" && currCommand[1] == ">=")
                {
                    List<int> filtered = new List<int>();
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= num)
                        {
                            filtered.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", filtered));
                    
                }
                else if (currCommand[0] == "Filter" && currCommand[1] == "<=")
                {
                    List<int> filtered = new List<int>();
                    int num = int.Parse(currCommand[2]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= num)
                        {
                            filtered.Add(numbers[i]);
                        }
                    }
                    Console.WriteLine(string.Join(" ", filtered));
                    
                }
                command = Console.ReadLine();
            }
            
            if (isChanged == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}

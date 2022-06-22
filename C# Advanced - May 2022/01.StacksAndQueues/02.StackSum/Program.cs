using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();
            
            while (command != "end")
            {
                string[] currCommand = command.Split();
                if (currCommand[0] == "add")
                {
                    stack.Push(int.Parse(currCommand[1]));
                    stack.Push(int.Parse(currCommand[2]));
                }
                else if (currCommand[0] == "remove")
                {
                     
                    if (stack.Count <= int.Parse(currCommand[1]))
                    {
                        
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(currCommand[1]); i++)
                        {
                            stack.Pop();
                        }
                        
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            int Sum = 0;
            foreach (var num in stack)
            {
                Sum += num;
            }            
            
            Console.WriteLine($"Sum: {Sum}");                     
        }
    }
}
//Create a program that:
//•	Reads an input of integer numbers and adds them to a stack.
//•	Reads and executes commands until "end" is received.


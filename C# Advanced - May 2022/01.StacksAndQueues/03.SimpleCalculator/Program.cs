using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> calculator = new Stack<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());

            while (calculator.Count > 1)
            {
                int operator1 = int.Parse(calculator.Pop());
                string action = calculator.Pop();
                int operator2 = int.Parse(calculator.Pop());

                if (action == "+")
                {
                    calculator.Push((operator1 + operator2).ToString());
                }
                else if (action == "-")
                {
                    calculator.Push((operator1 - operator2).ToString());
                
                }

            }
            Console.WriteLine(calculator.Pop());
        }
    }
}

//Create a simple calculator that can evaluate simple expressions with only addition and subtraction. There will not be any parentheses. Numbers and operations are space-separated.
//Solve the problem using a Stack.


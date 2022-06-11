using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.ReverceAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            foreach (var letter in text)
            {
                stack.Push(letter);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
//Create a program that:
//•	Reads an input string
//•	Reverses it backwards using a Stack< T >
//•	Prints the result back at the console

using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Queue<string> customers = new Queue<string>();
            while (command != "End")
            {
                if (command != "Paid")
                {
                    customers.Enqueue(command);
                }
                
                if (command == "Paid")
                {
                    foreach (var customer in customers)
                    {
                        Console.WriteLine(customer);
                    } 
                    customers.Clear();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");

        }
    }
}
//You are given a sequence of input strings, each staying on a separate line. Each input string holds either a customer name, or the command “Paid” or the command “End”.

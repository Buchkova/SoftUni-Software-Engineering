using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var registeredUsers = new Dictionary<string, string>();
            var unregisteredUsers = new Dictionary<string, int>();
            
            for (int i = 0; i < commands; i++)
            {
                string[] token = input.Split();
                string cmd = token[0];
                string name = token[1];

                if (cmd == "register")
                {                  
                    string regNum = token[2];
                    if (!registeredUsers.ContainsKey(name))
                    {
                        registeredUsers.Add(name, regNum);
                        Console.WriteLine($"{name} registered {regNum} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {regNum}");
                    }
                }
                else if (cmd == "unregister")
                {
                    if (registeredUsers.ContainsKey(name))
                    { 
                        unregisteredUsers.Add(name, 0);
                        Console.WriteLine($"{name} unregistered successfully");
                        registeredUsers.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }

                }
                input = Console.ReadLine();
            }
            foreach (var user in registeredUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}

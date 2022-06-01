using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (line != "stop")
            {
                string element = line;
                int quality = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(element))
                {
                    resources.Add(element, 0);
                }
                resources[element] += quality;

                line = Console.ReadLine(); 
            }
            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}

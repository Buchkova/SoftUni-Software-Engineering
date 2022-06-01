using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var programs = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                string[] token = input.Split(" : ");
                string course = token[0];
                string teacher = token[1];
                if (!programs.ContainsKey(course))
                {
                    programs.Add(course, new List<string>());                    
                }                
                    programs[course].Add(teacher);
                
                input = Console.ReadLine();
            }
            foreach (var program in programs.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{program.Key.Trim()}: {program.Value.Count}");
                foreach (var name in program.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}

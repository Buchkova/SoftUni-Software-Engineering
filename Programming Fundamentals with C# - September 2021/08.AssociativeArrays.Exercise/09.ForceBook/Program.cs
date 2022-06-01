using System;
using System.Linq;
using System.Collections.Generic;

namespace forceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceMembers = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                    break;

                string forceUser = string.Empty;
                string forceSide = string.Empty;
                if (input.Contains('|'))
                {
                    string[] currInfo = input.Split(" | ");
                    forceSide = currInfo[0];
                    forceUser = currInfo[1];

                    if (!forceMembers.ContainsKey(forceSide))
                    {
                        forceMembers.Add(forceSide, new List<string>());
                    }

                    if (!forceMembers[forceSide].Contains(forceUser) && !forceMembers.Values.Any(users => users.Contains(forceUser)))
                    {
                        forceMembers[forceSide].Add(forceUser);
                    }

                }
                else if (input.Contains("->"))
                {
                    string[] currInfo = input.Split(" -> ");
                    forceUser = currInfo[0];
                    forceSide = currInfo[1];
                    if (!forceMembers.Values.Any(users => users.Contains(forceUser)))
                    {
                        if (!forceMembers.ContainsKey(forceSide))
                        {
                            forceMembers.Add(forceSide, new List<string>());
                        }
                        forceMembers[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        foreach (var sides in forceMembers.Where(sides => sides.Value.Contains(forceUser)))
                        {
                            sides.Value.Remove(forceUser);
                        }

                        if (!forceMembers.ContainsKey(forceSide))
                        {
                            forceMembers.Add(forceSide, new List<string>());
                        }
                        forceMembers[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }

            var outputList = forceMembers.Where(x => x.Value.Count > 0);

            foreach (var side in outputList.OrderByDescending(x => x.Value.Count).ThenBy(z => z.Key).ToDictionary(x => x.Key, z => z.Value))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                side.Value.Sort();
                foreach (string user in side.Value)
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
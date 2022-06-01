using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var companies = new SortedDictionary<string, List<string>>();

            while (command != "End")
            {
                var token = command.Split(" -> ");
                string companyName = token[0];
                string employeeId = token[1];
                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
                if (!companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }
                
                command = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}

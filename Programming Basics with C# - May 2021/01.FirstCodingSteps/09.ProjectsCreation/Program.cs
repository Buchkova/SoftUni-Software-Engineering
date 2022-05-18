using System;

namespace _09.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int hoursPerProject = 3;
            int totalPtrojectHours = projectCount * hoursPerProject;

            Console.WriteLine($"The architect {architectName} will need {totalPtrojectHours} hours to complete {projectCount} project/s.");


           
        }
    }
}

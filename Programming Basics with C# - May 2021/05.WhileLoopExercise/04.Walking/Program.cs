using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSteps = 0;

            while (input != "Going home")
            {
                int currentSters = int.Parse(input);
                totalSteps += currentSters;

                if (totalSteps >= 10000)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Going home")
            {
                int goingHomeSteps = int.Parse(Console.ReadLine());
                totalSteps += goingHomeSteps;

            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}

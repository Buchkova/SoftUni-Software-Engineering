using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int allowedPoorGrades = int.Parse(Console.ReadLine());

            string problem = Console.ReadLine();

            int poorGradesCounter = 0;
            int gradesSum = 0;
            int gradesCounter = 0;
            string lastProblem = string.Empty;

            while (problem != "Enough")
            {
                lastProblem = problem;

                int grade = int.Parse(Console.ReadLine());
                gradesSum += grade;
                gradesCounter++;

                if (grade <= 4)
                {
                    poorGradesCounter ++;

                    if (poorGradesCounter == allowedPoorGrades)
                    {
                        Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");

                        break;
                    }
                }

                problem = Console.ReadLine();
            }

            double averageGrade = (double)gradesSum / gradesCounter;

            if (problem == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrade:F2}");
                Console.WriteLine($"Number of problems: {gradesCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}

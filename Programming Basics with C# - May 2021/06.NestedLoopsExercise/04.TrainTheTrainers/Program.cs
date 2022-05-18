using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfJury = int.Parse(Console.ReadLine());

            string presentation = Console.ReadLine();

            double totalSum = 0;
            int numOfPresentation = 0;

            while (presentation != "Finish")
            {
                double sum = 0;
                numOfPresentation++;

                for (int i = 0; i < numOfJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }

                double averageGrade = sum / numOfJury;
                totalSum += averageGrade;

                Console.WriteLine($"{presentation} - {averageGrade:f2}.");

                presentation = Console.ReadLine();
            }

            double totalAverage = totalSum / numOfPresentation;
            Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");
        }
    }
}

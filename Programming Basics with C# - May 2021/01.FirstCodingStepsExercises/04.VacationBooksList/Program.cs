using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int totalDaysForBook = int.Parse(Console.ReadLine());

            double totalTimeReading = sumPages / pagesPerHour;
            double totalHoursPerDay = totalTimeReading / totalDaysForBook;

            Console.WriteLine(totalHoursPerDay);
        }
    }
}

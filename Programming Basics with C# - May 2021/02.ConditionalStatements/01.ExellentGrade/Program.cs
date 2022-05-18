using System;

namespace _01.ExellentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            bool isExellentGrade = grade >= 5.5;

            if (grade >= 5.5) //може и директно if (isExcelentGrade)
            {

                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not Excellent!");
            }
            
        }
    }
}

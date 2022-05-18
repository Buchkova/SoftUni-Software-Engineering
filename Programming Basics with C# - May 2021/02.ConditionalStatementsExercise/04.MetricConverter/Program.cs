using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMwtric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            if (inputMwtric == "mm")
            {
                number = number / 1000;
            }
            else if (inputMwtric == "cm")
            {
                number = number / 100;
            }
            if (outputMetric == "mm")
            {
                number = number * 1000;
            }
            else if (outputMetric == "cm")
            {
                number = number * 100;
            }

            Console.WriteLine($"{number:F3}");

        }
    }
}

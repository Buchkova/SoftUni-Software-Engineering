using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double Deposit = double.Parse(Console.ReadLine());
            int DepositDeadLine = int.Parse(Console.ReadLine());
            double YearPercent = double.Parse(Console.ReadLine());

            double intersest = Deposit * YearPercent / 100;
            double intersestPerMounth = intersest / 12;
            double totalSum = Deposit + (DepositDeadLine * intersestPerMounth); 

            Console.WriteLine(totalSum);

        }
    }
}

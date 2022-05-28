using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            raisedToPower(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        }

        private static void raisedToPower(double number, double power)
        {
            
            Console.WriteLine(Math.Pow(number, power));
        }
    }
}

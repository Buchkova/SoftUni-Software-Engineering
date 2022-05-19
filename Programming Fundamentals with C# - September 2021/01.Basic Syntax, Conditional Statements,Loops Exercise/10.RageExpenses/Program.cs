using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0;

            for (int currGame = 1; currGame <= lostGame; currGame++)
            {
                if (currGame % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (currGame % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (currGame % 6 == 0)
                {
                    expenses += keyboardPrice;
                }
                if (currGame % 12 == 0)
                {
                    expenses += displayPrice;
                }

               
               
            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");

        }
    }
}

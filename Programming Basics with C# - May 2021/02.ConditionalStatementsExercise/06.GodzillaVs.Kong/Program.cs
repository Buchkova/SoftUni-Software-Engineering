using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. От конзолата се четат 3 реда:
            //Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Брой на статистите – цяло число в интервала[1 … 500]
            //Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]

            double movieBudget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double pricePerClothes = double.Parse(Console.ReadLine());
            

            //2.Декорът за филма е на стойност 10% от бюджета. 
            //  При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.

            double decorPrice = movieBudget * 0.1;
            double totalClothesPrice = actors * pricePerClothes;
            
           
            if (actors > 150)
            {
                totalClothesPrice = totalClothesPrice - totalClothesPrice * 0.10;
            }

            double totalSum = decorPrice + totalClothesPrice;

            if (totalSum > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - movieBudget:F2} leva more."); 
            }
            else if (totalSum <= movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - totalSum:F2} leva left.");
            }
            

            //3. На конзолата трябва да се отпечатат два реда:
            //Ако парите за декора и дрехите са повече от бюджета:
            //"Not enough money!"
            //"Wingard needs {парите недостигащи за филма} leva more."
            //Ако парите за декора и дрехите са по малко или равни на бюджета:
            // "Action!"
            //"Wingard starts filming with {останалите пари} leva left."
            //Резултатът трябва да е форматиран до втория знак след десетичната запетая.






        }
    }
}

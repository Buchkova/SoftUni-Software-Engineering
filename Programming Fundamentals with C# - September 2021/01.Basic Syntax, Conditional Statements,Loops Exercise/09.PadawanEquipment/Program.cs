using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robersPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabersNum = Math.Ceiling(studentsCount * 1.10);
            double lightsabersTotal = lightsabersNum * lightsabersPrice;
            double freeBelts = Math.Floor(studentsCount / 6.0);


            double beltsTotal = (studentsCount - freeBelts) * beltsPrice;
            double robersTotal = studentsCount * robersPrice;

            double totalSum = lightsabersTotal + beltsTotal + robersTotal;

            if (budget >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else if (budget < totalSum)
            {
                Console.WriteLine($"John will need {Math.Abs(budget - totalSum):f2}lv more.");
            }

        }
    }
}

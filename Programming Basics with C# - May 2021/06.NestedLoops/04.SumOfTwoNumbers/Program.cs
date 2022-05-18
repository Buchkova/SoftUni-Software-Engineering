using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool conbinationHasBeenFound = false;

            for (int x = startOfInterval; x <= endOfInterval; x++)
            {
                for (int y = startOfInterval; y <= endOfInterval; y++)
                {
                    counter++;

                    if (x + y == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x} + {y} = {magicNumber})");
                        conbinationHasBeenFound = true;
                        break;
                    }
                }

                if (conbinationHasBeenFound)
                {
                    break;
                }
            }

            if (!conbinationHasBeenFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}

using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakePieces = lenght * width;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int currentPieces = int.Parse(input);
                cakePieces -= currentPieces; //cakePieces -= int.Parse(input);

                if (cakePieces <= 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (cakePieces > 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}

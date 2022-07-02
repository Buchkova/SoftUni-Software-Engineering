using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            DarkWizard darkWizard = new DarkWizard(name, level);

            Console.WriteLine(darkWizard.ToString());
        }
    }
}
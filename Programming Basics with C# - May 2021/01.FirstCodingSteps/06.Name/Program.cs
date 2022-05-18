using System;

namespace _06.Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            int age = 21;
            string nameFormated = $"{FirstName} {LastName}. Age: {age}";

            Console.WriteLine(nameFormated);
        }
    }
}

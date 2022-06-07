using System;

namespace _01._ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string reversed = "";
            while (line != "end")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                    
                }
                Console.WriteLine($"{line} = {reversed}");
                reversed = "";
                line = Console.ReadLine();
                
            }
            
        }
    }
}

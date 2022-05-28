using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (type == "int")
            {
                Console.WriteLine(printBiggestValue(int.Parse(a),int.Parse(b)));
            }
            else if (type == "char")
            {
                Console.WriteLine(printBiggestValue(char.Parse(a), char.Parse(b)));
            }
            else if (type == "string")
            {
                Console.WriteLine(printBiggestValue(a, b));
            }


  
        }

        private static int printBiggestValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        private static char printBiggestValue(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        private static string printBiggestValue(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}

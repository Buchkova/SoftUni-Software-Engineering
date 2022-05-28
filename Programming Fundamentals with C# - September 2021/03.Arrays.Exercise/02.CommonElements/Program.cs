using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(" ");
            string[] arrTwo = Console.ReadLine().Split(" ");

            foreach (var elementsTwo in arrTwo)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    string elementsOne = arrOne[i];
                    if (elementsTwo == elementsOne)
                    {
                        Console.Write(elementsOne + " ");
                        break;
                    }
                }
            }
        }
    }
}

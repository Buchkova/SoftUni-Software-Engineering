using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int from = int.Parse(Console.ReadLine());
            int to = 10;

            do
            {
                Console.WriteLine($"{num} X {from} = {num * from}");
                from++;
            } while (from <= to);

           
        }
    }
}

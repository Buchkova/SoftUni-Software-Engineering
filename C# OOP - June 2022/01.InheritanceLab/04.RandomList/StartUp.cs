using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList randomList = new RandomList
            {
                "Ivan",
                "Victor",
                "Aleks"
            };

            Console.WriteLine(randomList.RandomString());
        }
    }
}

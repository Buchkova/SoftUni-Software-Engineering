using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double hightOfHouse = double.Parse(Console.ReadLine());
            double lengthOfWall = double.Parse(Console.ReadLine()); //stranichnata stena
            double hightOfRoof = double.Parse(Console.ReadLine()); //visochina an pokriva

            double sideWall = hightOfHouse * lengthOfWall;
            double sideWindow = 1.50 * 1.50;

            double sideWallsWithoutWindows = (2 * sideWall) - (2 * sideWindow);

            double frontBackWall = hightOfHouse * hightOfHouse;
            double frontDoor = 1.20 * 2.00;

            double frontBackWallWithoutDoor = (2 * frontBackWall) - frontDoor;

            double green = (sideWallsWithoutWindows + frontBackWallWithoutDoor) / 3.4;

            double sideRoofWalls = 2 * (hightOfHouse * lengthOfWall);
            double frontRoofWall = 2 * ((hightOfHouse * hightOfRoof) / 2);

            double red = (sideRoofWalls + frontRoofWall) / 4.3;

            Console.WriteLine($"{green:f2}");
            Console.WriteLine($"{red:f2}");


        }
    }
}

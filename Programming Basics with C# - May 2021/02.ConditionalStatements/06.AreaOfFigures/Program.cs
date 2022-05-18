using System;

namespace _06.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята
            //лицето й. Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник
            //    (triangle). На първия ред на входа се чете вида на фигурата(square, rectangle, circle или triangle).
            //    Ако фигурата е квадрат, на следващия ред се чете едно число -дължина на страната му.
            //    Ако фигурата е правоъгълник, на следващите два реда четат две числа -дължините на страните му.
            //    Ако фигурата е кръг, на следващия ред чете едно число - радиусът на кръга.
            //    Ако фигурата е триъгълник, на следващите два реда четат две числа -дължината на страната му и
            //    дължината на височината към нея.
            //    Резултатът да се закръгли до 3 цифри след десетичната точка.


            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double area = sideA * sideA;

                Console.WriteLine("{0:F3}", area);
            }
            else if (figureType == "rectangle") 
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = sideA * sideB;
                
                Console.WriteLine("{0:F3}", area);
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * (radius * radius);
                
                Console.WriteLine("{0:F3}", area);
            }
            else if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (side * height) / 2;
                
                Console.WriteLine("{0:F3}", area);
            }


        }
    }
}

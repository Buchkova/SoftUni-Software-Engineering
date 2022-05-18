using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = (double)num1 / num2;  //result = num1 * 1.0 / num2;
                    }
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 % num2;
                    }
                    break;
                    
            }
            if (symbol == "+" || symbol == "-" || symbol == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {symbol} {num2} = {result} - odd");
                }
            }
            else if (symbol == "/" && num2 != 0)
            {
                Console.WriteLine($"{num1} {symbol} {num2} = {result:F2}");
            }
            else if (symbol == "%" && num2 != 0)
            {
                Console.WriteLine($"{num1} {symbol} {num2} = {result}");
            }

        }
    }
}

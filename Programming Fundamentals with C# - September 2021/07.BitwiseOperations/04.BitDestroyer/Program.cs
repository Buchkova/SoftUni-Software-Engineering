using System;

namespace _04.BitDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Declare four variables (n, p, mask and newNumber). 
            //2.Read the user input from the console.
            //3.Set the value of the bit at position p to 0: 
            //a.Shift the number 1, p times to the left(where p is the position) by using the << operator. In that way the bit we want to delete will be at position p. Save the resulting value in mask;
            //b.Invert the mask(e.g.we move the number 1, 3 times and we get 00001000, after inverting we get 11110111).
            //c.Use & mask operator expression to set the value of a number to 0.By using the following formulae(n & mask) you copy all the bits of the number and you set the bit at position p to 0;
            //d.Save the result in newNumber;
            //4.Print the result on the console.
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int mask = ~(1 << position);
            
            int newNumber = (number & mask);
            Console.WriteLine(newNumber);



        }
    }
}

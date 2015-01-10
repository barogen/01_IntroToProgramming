/*
 * Problem 8. Square Root
 * Create a console application that calculates and prints the square root of the number 12345.
 * Find in Internet “how to calculate square root in C#”.
 */

namespace _08.SquareRoot
{

    using System;

    class SquareRoot
    {
        static void Main()
        {
            //Малко цвят :)
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Math.Sqrt(12345));
            Console.ResetColor();
        }
    }
}

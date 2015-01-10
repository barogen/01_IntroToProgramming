/*
 * Problem 14.* Current Date and Time
 * Create a console application that prints the current date and time. Find out how in Internet.
 */


namespace PrintCurrentTimeDate
{

    using System;

    class CurrentTimeDate
    {
        static void Main()
        {
            //
            //Форматирането на датата е направено, за да може при различни формата на датата на компютъра тя да се показва по един и същ начин.
            //
            DateTime now = DateTime.Now;
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", now);
        }
    }
}

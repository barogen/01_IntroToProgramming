/*
 * Problem 15.* Age after 10 Years
 * Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */

namespace _15.AgeАfterTenYears
{
    using System;
    using System.Globalization;

    class AgeАfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Pleace enter your birth date using folowing format dd.MM.yyyy:");
            string birthStr = Console.ReadLine();
            DateTime bDate = Convert.ToDateTime(birthStr);

            DateTime cDate = DateTime.Now;
            
            if (cDate.DayOfYear > bDate.DayOfYear)
                {
                int cAge = cDate.Year - bDate.Year;
                Console.WriteLine("Your current age is: {0}", cAge);
                int fAge = cAge + 10;
                Console.WriteLine("Your age after 10 years will be: {0}", fAge);
                }
            else
                {
                int cAge = cDate.Year - bDate.Year - 1;
                Console.WriteLine("Your current age is: {0}", cAge);
                int fAge = cAge + 10;
                Console.WriteLine("Your age after 10 years will be: {0}", fAge);
                }
        }
    }
}

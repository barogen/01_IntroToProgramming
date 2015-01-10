/*
 * Problem 9. Print a Sequence
 * Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */

namespace _09.PrintASequence
{

    using System;

    class SequenceNumber
    {
        static void Main()
        {
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
                else
                {
                    Console.Write("{0}, ", -i);
                }
            }
        }
    }
}

/*
 * Коментар за GitHub
 * Ще се радвам, ако може някой да ми препоръча как да махна последната запетайка от sequence-а,
 * а също така и 'Press any key to continue...' да отиде на нов ред.
 */
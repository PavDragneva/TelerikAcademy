//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.
using System;
class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int maskAndNumber = number & mask;
        Console.WriteLine("The bit on position " + position + " is 1 - " + (maskAndNumber >> position == 1));
    }
}


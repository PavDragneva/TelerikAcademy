//Write an expression that extracts from given integer n the value of given bit at index p.
using System;
class ExtractBitfromInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position for checking: ");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int maskAndNumber = number & mask;
        int bit = maskAndNumber >> position;
        Console.WriteLine("Thr bit on position {0} is {1}.", position, bit);
    }
}


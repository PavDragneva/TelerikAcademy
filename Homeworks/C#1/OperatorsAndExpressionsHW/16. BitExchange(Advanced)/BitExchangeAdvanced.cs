//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 
//32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        //I'm using conditional statement for checking if the values of p and q are in the correct range and if they are overlapping.
         if((p+k>32) || (q+k>32) || (q < 0) || (p < 0))
        {
            Console.WriteLine("out of range");
        }
        else if ((p + k >= q && q>p) || (q+k >= p && p>q))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            //After that I use for loop for extracting bits and replacing their positions.
            for (int i = 0; i < k; i++)
            {
                long bitP = ExtractBit(number, p + i);
                long bitQ = ExtractBit(number, q + i);
                number = ReplaceBit(number, bitP, q + i);
                number = ReplaceBit(number, bitQ, p + i);
            }
            Console.WriteLine(number);
        }
        //I'm using two methods. One for extracting the bits. And one for replacing the bits. 
    }
    static long ExtractBit (long number, int position)
    {
        int mask = 1 << position;
        long maskAndNumber = mask & number;
        long bit = maskAndNumber >> position;
        return bit;
    }
    static long ReplaceBit(long number, long bit, int position)
    {
        if (bit == 0)
        {
            int mask = ~(1 << position);
            long maskAndNum = number & mask;
            return maskAndNum;
        }
        else
        {
            long mask = 1 << position;
            long maskAndNum = number | mask;
            return maskAndNum;
        }
    }
}
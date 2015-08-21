//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;
class BitsExchange
{
    static void Main()
    {
        //I'm using two methods. One for extracting the bits on positions 3, 4, 5, 24, 25 and 26. 
        //And one for replacing the bits on positins 3, 4, 5, 24, 25 and 26.
        Console.Write("Enter integer: ");
        int number = int.Parse(Console.ReadLine());
        int thirdBit = ExtractBit(number, 3);
        int fourthBit = ExtractBit(number, 4);
        int fifthBit = ExtractBit(number, 5);
        int twentyfourthBit = ExtractBit(number, 24);
        int twentyfifthBit = ExtractBit(number, 25);
        int twentysixtBit = ExtractBit(number, 26);
        int mask = thirdBit;
        number = ReplaceBit(number, thirdBit, 24);
        number = ReplaceBit(number, fourthBit, 25);
        number = ReplaceBit(number, fifthBit, 26);
        number = ReplaceBit(number, twentyfourthBit, 3);
        number = ReplaceBit(number, twentyfifthBit, 4);
        number = ReplaceBit(number, twentysixtBit, 5);
        Console.WriteLine("The result is - {0}", number);
    }
    static int ExtractBit (int number, int position)
    {
        int mask = 1 << position;
        int maskAndNumber = mask & number;
        int bit = maskAndNumber >> position;
        return bit;
    }
    static int ReplaceBit(int number, int bit, int position)
    {
        if (bit == 0)
        {
            int mask = ~(1 << position);
            int maskAndNum = number & mask;
            return maskAndNum;
        }
        else
        {
            int mask = 1 << position;
            int maskAndNum = number | mask;
            return maskAndNum;
        }
    }
}


//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.
using System;
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter a integer(n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value(v): ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a position(p): ");
        int p = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            int maskAndNum = n & mask;
            Console.WriteLine("When we put {0} on position {1} the result is {2}", v, p, maskAndNum);
        }
        else
        {
            int mask = 1 << p;
            int maskAndNum = n | mask;
            Console.WriteLine("When we put {0} on position {1} the result is {2}", v, p, maskAndNum);
        }
    }
}


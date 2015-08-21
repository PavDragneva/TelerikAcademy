using System;
using System.Numerics;

//Problem 18.* Trailing Zeroes in N!
//• Write a program that calculates with how many zeroes the factorial
//of a given number  n  has at its end.
//• Your program should work well for very big numbers, e.g.  n=100000 .

//Examples:
//n       trailing zeroes of n!       explaination
//10      2                           3628800 
//20      4                           2432902008176640000 
//100000  24999                       think why 

class Trailing_Zeroes_in_Nfact
{
    static void Main()
    {
        //On every +5 on N, ther is one additional 0 on the end of the factorial. On every +5^2 there is  two additional 0s on the end of the factorial. On every 5^3 there is three aditionsl 0s and so on.
        //Example:
        // n = 10 - two 0s. 10 - 2*5;
        //n = 15 - three 0s. 15 - 3*5;
        //n = 25 - six 0s. 25 - 5*5 and one additional 0 from - 1*(5^2);
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int mask = n;
        int counter = 0;
        // Calculating how many powers of 5 there is in the N.
        while(mask > 0)
        {
        mask /= 5;
        counter++;
        }
        int power = 1;
        int zeroes = 0;
        //Calculating the zeroes on the end of the factorial. Every additional power of 5 in N brings additional 0.
        for(int i = 1; i <= counter; i++)
        {
         power *=  5;
         zeroes += (n / power);
        }
        Console.WriteLine("Zeros in n! - {0}", zeroes);
    }
}

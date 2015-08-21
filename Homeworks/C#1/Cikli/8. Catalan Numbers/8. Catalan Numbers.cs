using System;
using System.Numerics;

//Problem 8. Catalan Numbers•
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula 
//• Write a program to calculate the  nth  Catalan number by given  n  (1 < n < 100). 

//Examples:
//n   Catalan(n)
//0   1 
//5   42 
//10  16796 
//15  9694845 

class Catalan_Numbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;
        BigInteger nPlusOne = 1;
        BigInteger doubleNFactoriel = 1;
        if (n > 0)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                doubleNFactoriel *= i;
                if (i <= n)
                {
                    nFactoriel *= i;
                }
                if (i <= (n + 1))
                {
                    nPlusOne *= i;
                }
            }
            BigInteger sum = doubleNFactoriel / (nPlusOne * nFactoriel);
            Console.WriteLine("(2n)!/(n+1)!n! = {0}", sum);
        }
        else
        {
            Console.WriteLine("N must to be bigger than 0!");
        }
    }
}

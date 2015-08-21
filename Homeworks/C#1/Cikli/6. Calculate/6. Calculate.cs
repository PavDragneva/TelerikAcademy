using System;
using System.Numerics;

//Problem 6. Calculate N! / K!
//• Write a program that calculates  n! / k!  for given  n  and  k  (1 < k < n < 100).
//• Use only one loop.

//Examples:
//n       k       n! / k!
//5       2       60 
//6       5       6 
//8       3       6720 

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;
        BigInteger kFactoriel = 1;
        for(int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
            if(i <= k)
            {
                kFactoriel *= i;
            }
        }
        BigInteger sum = nFactoriel/kFactoriel;
        Console.WriteLine("n!/k! = {0}", sum);
    }
}

using System;
using System.Numerics;
//Problem 7. Calculate N! / (K! * (N-K)!)
//• In combinatorics, the number of ways to choose  k  different members out 
//of a group of  n  different elements (also known as the number of combinations)
//is calculated by the following formula: "https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png"
//For example, there are 2598960 ways to withdraw 5 cards out of a standard deck 
//of 52 cards.• Your task is to write a program that calculates  n! / (k! * (n-k)!)
//for given  n  and  k  (1 < k < n < 100). Try to use only two loops.

//Examples:
//n   k   n! / (k! * (n-k)!)
//3   2   3 
//4   2   6 
//10  6   210 
//52  5   2598960 

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
        BigInteger nMinusK = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
            if(k >= i)
            {
                kFactoriel *= i;
            }
        }
        for (int i = 1; i <= (n - k); i++)
        {
            nMinusK *= i;
        }
        BigInteger sum = nFactoriel / (kFactoriel * nMinusK);
            Console.WriteLine("n! / (k! * (n-k)!) = {0}", sum);
    }
}

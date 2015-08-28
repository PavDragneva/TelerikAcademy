//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the Sieve of Eratosthenes algorithm.
using System;
using System.Collections.Generic;
class PrimeNumbers
{
    static void Main()
    {
        int n = 10000000;
        bool[] notPrime = new bool[n];
        Console.Write(1 + " ");
        for (int i = 2; i < n; i++)
        {
            if (!notPrime[i])
            {
                for (int j = 2; i * j < n; j++)
                {
                    notPrime[i * j] = true;
                }
            }
        }
        for (int i = 2; i < n; i++)
        {
            if (!notPrime[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}


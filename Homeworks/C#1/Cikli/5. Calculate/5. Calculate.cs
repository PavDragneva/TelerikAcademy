using System;
using System.Numerics;

//Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
//• Write a program that, for a given two integer numbers  n  and  x ,
//calculates the sum  S = 1 + 1!/x + 2!/x2+ … + n!/xn .
//• Use only one loop. Print the result with  5  digits after the decimal point.

//Examples:
//n   x   S
//3   2   2.75000 
//4   3   2.07407 
//5   -4  0.75781 

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        double n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        double x = int.Parse(Console.ReadLine());
        double sum = 1;
        double factoriel = 1;
        double valueX = x;
        for(int i = 1; i <= n; i++)
        {
            factoriel *= i;
            sum += factoriel / x;
            x *= valueX;  
        }
        Console.WriteLine("S = {0:0.00000}", sum);
    }
}

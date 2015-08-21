using System;

//Problem 12.* Zero Subset
//• We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//• Assume that repeating the same subset several times is not a problem.

//Examples:
//numbers         result
//3 -2 1 1 8      -2 + 1 + 1 = 0 

//3 1 -7 35 22    no zero subset 

//1 3 -4 -2 -1    1 + -1 = 0 
//                1 + 3 + -4 = 0 
//                3 + -2 + -1 = 0 

//1 1 1 -1        -1 1 + -1 = 0 
//                1 + 1 + -1 + -1 = 0 

//0 0 0 0 0       0 + 0 + 0 + 0 + 0 = 0 

//Hint: you may check for zero each of the 32 subsets with 32  if  statements.

class Zero_Subset
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());
        if(a + b == 0)
        {
            Console.WriteLine(a + "+" + b + "=" + 0);
        }
        if(a + c == 0)
        {
            Console.WriteLine(a + "+" + c + "=" + 0);
        }
        if (a + d == 0)
        {
            Console.WriteLine(a + "+" + d + "=" + 0);
        }
        if (a + e == 0)
        {
            Console.WriteLine(a + "+" + e + "=" + 0);
        }
        if (b + c == 0)
        {
            Console.WriteLine(b + "+" + c + "=" + 0);
        }
        if (b + d == 0)
        {
            Console.WriteLine(b + "+" + d + "=" + 0);
        }
        if (b + e == 0)
        {
            Console.WriteLine(b + "+" + e + "=" + 0);
        }
        if (c + d == 0)
        {
            Console.WriteLine(c + "+" + d + "=" + 0);
        }
        if (c + e == 0)
        {
            Console.WriteLine(c + "+" + e + "=" + 0);
        }
        if (d + e == 0)
        {
            Console.WriteLine(d + "+" + e + "=" + 0);
        }
        if (a + b + c == 0)
        {
            Console.WriteLine(a + "+" + b +"+" + c +  "=" + 0);
        }
        if (a + b + d == 0)
        {
            Console.WriteLine(a + "+" + b + "+" + d + "=" + 0);
        }
        if (a + b + e == 0)
        {
            Console.WriteLine(a + "+" + b + "+" + e + "=" + 0);
        }
        if (a + c + d == 0)
        {
            Console.WriteLine(a + "+" + c + "+" + d + "=" + 0);
        }
        if (a + c + e == 0)
        {
            Console.WriteLine(a + "+" + c + "+" + e + "=" + 0);
        }
        if (a + d + e == 0)
        {
            Console.WriteLine(a + "+" + d + "+" + e + "=" + 0);
        }
        if (b + c + d == 0)
        {
            Console.WriteLine(b + "+" + c + "+" + d + "=" + 0);
        }
        if (b + c + e == 0)
        {
            Console.WriteLine(b + "+" + c + "+" + e + "=" + 0);
        }
        if (b + d + e == 0)
        {
            Console.WriteLine(b + "+" + d + "+" + e + "=" + 0);
        }
        if (c + d + e == 0)
        {
            Console.WriteLine(c + "+" + d + "+" + e + "=" + 0);
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine(a + "+" + b + "+" + c + "+" + d + "=" + 0);
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine(a + "+" + b + "+" + c + "+" + e + "=" + 0);
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine(b + "+" + c + "+" + d + "+" + e + "=" + 0);
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine(a + "+" + b + "+" + c + "+" + d + "+" + e + "=" + 0);
        }
        
    }
}




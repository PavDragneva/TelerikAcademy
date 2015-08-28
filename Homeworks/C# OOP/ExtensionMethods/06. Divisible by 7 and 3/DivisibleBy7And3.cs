//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
class DivisibleBy7And3
{
    static void Main()
    {
        int[] arr = new int[] { 3, 9, 7, 6, 21, 765, 4, 324, 9, 12, 3, 42, 8, 84, 3 };
        var divisible = arr.Where(num => num % 21 == 0);
        var divisibleWithLINQ = 
                                from num in arr
                                where num % 21 == 0
                                select num;
        Console.WriteLine("Divisible by 7 and 3 with lambda expressions: {0}\nDivisible by 7 and 3 with LINQ: {1}", 
            string.Join(" ", divisible), string.Join(" ", divisibleWithLINQ));
    }
}
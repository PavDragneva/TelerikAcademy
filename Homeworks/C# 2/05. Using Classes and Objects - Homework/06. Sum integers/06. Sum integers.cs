using System;
using System.Linq;
//•	You are given a sequence of positive integer values written into a string, separated by spaces.
//•	Write a function that reads these values from given string and calculates their sum.
class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter some numbers: ");
        string numsString = Console.ReadLine();
        int[] numsArr = numsString
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int sum = numsArr.Sum();
        Console.WriteLine(sum);
    }
}


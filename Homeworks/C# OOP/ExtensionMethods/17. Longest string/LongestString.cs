//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
using System;
using System.Linq;
class LongestString
{
    static void Main(string[] args)
    {
        string[] arr = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "twenty-five", "null" };
        int max = arr[0].Length;
        var longest = (from word in arr
                       orderby word.Length
                       select word).ToArray()[arr.Length - 1];
        Console.WriteLine(longest);
    }
}
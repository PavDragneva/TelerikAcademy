using System;
using System.Linq;
//•	Write a program that reads a string, reverses it and prints the result at the console.
class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        char[] arr = text.ToCharArray();
        Array.Reverse(arr);
        string textReverse = string.Join("", arr);
        Console.WriteLine(textReverse);
    }
}

using System;
using System.Text;
//•	Write a program that reads a string from the console and replaces all series 
//  of consecutive identical letters with a single one.
class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        StringBuilder newStr = new StringBuilder();
        newStr.Append(text);
        for(int i = 0; i < newStr.Length-1; i++)
        {
            if(newStr[i] == newStr[i+1])
            {
                newStr.Remove(i + 1, 1);
                i--;
            }
        }
        Console.WriteLine(newStr);
    }
}


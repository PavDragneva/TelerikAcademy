using System;
using System.Linq;
/* •	We are given a string containing a list of forbidden words and a text containing some of 
       * these words.
         •	Write a program that replaces the forbidden words with asterisks.*/
class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.Write("Enter forbidden words: ");
        string wordsStr = Console.ReadLine();
        string[] forbiddeWords = wordsStr
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        for(int i = 0; i < forbiddeWords.Length; i++)
        {
            text = text.Replace(forbiddeWords[i], new string('*', forbiddeWords[i].Length));
        }
        Console.WriteLine(text);
    }
}


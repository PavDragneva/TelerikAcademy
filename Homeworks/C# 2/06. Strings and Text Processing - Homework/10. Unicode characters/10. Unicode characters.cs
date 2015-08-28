using System;
using System.Text;
//•	Write a program that converts a string to a sequence of C# Unicode character literals.
//•	Use format strings.
class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter some word: ");
        string word = Console.ReadLine();
        char[] wordSymb = word.ToCharArray();
        StringBuilder newWord = new StringBuilder();
        for (int i = 0; i < wordSymb.Length; i++)
        {
            newWord.Append(string.Format("\\u" + "{0:X4}", (int)wordSymb[i]));
        }
        Console.WriteLine(newWord);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
//•	Write a program for extracting all email addresses from given text.
//•	All sub-strings that match the format @… should be recognized as emails.
class ExtractEMails
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        List<string> words = text.Split(' ').ToList();
        for(int i = 0; i < words.Count; i++)
        {
            if(words[i].Contains('@'))
            {
                Console.WriteLine(words[i].TrimEnd(',','.','?','!'));
            }
        }
    }
}


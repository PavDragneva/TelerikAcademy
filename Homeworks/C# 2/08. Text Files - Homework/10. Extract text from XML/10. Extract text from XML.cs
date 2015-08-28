using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
//•	Write a program that extracts from given XML file all the text without the tags.
class ExtractTextFromXML
{
    static void Main()
    {
        Console.Write("Enter path to the file: ");
        StreamReader reader = new StreamReader(Console.ReadLine());
        string text = reader.ReadToEnd();
        text = text.Replace("<", " <");
        text = text.Replace(">", "> ");
        List<string> words = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
        for(int i = 0; i < words.Count; i++)
        {
            if(words[i].Contains("<")|| words[i].Contains(">"))
            {
                words[i] = null;
            }
        }
        string newText = string.Join(" ", words).ToString();
        words.Clear();
        words = newText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
        newText = string.Join(" ", words).ToString();
        Console.WriteLine(newText.TrimEnd());
    }
}


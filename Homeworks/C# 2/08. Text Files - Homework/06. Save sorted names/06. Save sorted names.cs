using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
//•	Write a program that reads a text file containing a list of strings, sorts them
//  and saves them to another text file.
class SaveSortedNames
{
    static void Main()
    {
        Console.Write("Enter path to the file with words sepsretef by comma: ");
        StreamReader reader = new StreamReader("C:\\Users\\Pav\\Desktop\\C#\\12.txt");
        string words = reader.ReadToEnd();
        List<string> wordsList = words.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        wordsList.Sort();
        Console.Write("Enter path to the new text file: ");
        StreamWriter writer = new StreamWriter("C:\\Users\\Pav\\Desktop\\C#\\8.txt");
        foreach(string sortedWords in wordsList)
        {
            writer.WriteLine(sortedWords);
            writer.Flush();
        }
        Console.WriteLine("File is written!");
    }
}


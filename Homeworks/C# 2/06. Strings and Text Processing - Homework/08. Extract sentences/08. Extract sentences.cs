using System;
using System.Collections.Generic;
using System.Linq;
//•	Write a program that extracts from a given text all sentences containing given word.
class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        List<string> sentence = text.Split(new char[] { '.' }).ToList();
        for (int i = 0; i < sentence.Count; i++)
        {
           if(sentence[i].Contains(word))
           {
               List<string> words = sentence[i].Split(new char[] { ' ', ',', '-', '/', '\\', '+', '=' },StringSplitOptions.RemoveEmptyEntries).ToList();
               for (int j = 0; j < words.Count; j++)
               {
                   if(words[j] == word)
                   {
                       Console.Write(sentence[i]);
                   }
               } 
           }
        }
        Console.WriteLine();
    }
}


using System;
using System.Collections.Generic;
/*•	A dictionary is stored as a sequence of text lines containing words and 
         * their explanations.
          •	Write a program that enters a word and translates it by using the dictionary.*/
class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        Dictionary<string, string> dictonary = new Dictionary<string, string>();
        dictonary.Add(".NET", "platform for applications from Microsoft");
        dictonary.Add("CLR", "managed execution environment for .NET");
        dictonary.Add("namespace", "hierarchical organization of classes");
        if(dictonary.ContainsKey(word))
        {
            string value = dictonary[word];
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("Not found!");
        }
    }
}

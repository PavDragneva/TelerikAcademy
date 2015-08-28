using System;
using System.Linq;
using System.Collections.Generic;
//•	Write a program that reads a string from the console and lists all different words in the 
//  string along with information how many times each word is found.
class WordsCount
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine().ToLower();
        List<string> textList = text.Split(new char[] { ' ', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        HashSet<string> words = new HashSet<string>();
        for (int i = 0; i < textList.Count; i++)
        {
                words.Add(textList[i]);
        }
        List<string> wordsList = new List<string>();
        foreach (string word in words)
        {
            wordsList.Add(word);
        }
        List<int> counter = new List<int>();
        int coun = 0;
        for (int i = 0; i < wordsList.Count; i++)
        {
            for (int j = 0; j < textList.Count; j++)
            {
                if (textList[j] == wordsList[i])
                {
                    coun++;
                }
            }
            counter.Add(coun);
            coun = 0;
        }
        for (int i = 0; i < counter.Count; i++)
        {
            Console.WriteLine("{0} --> {1}times", wordsList[i], counter[i]);
        }
    }
}

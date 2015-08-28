using System;
using System.Collections.Generic;
using System.Linq;
//•	Write a program that reverses the words in given sentence.
class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter sentence: ");
        string sentence = "C# is not C++, not PHP and not Delphi!"; //Console.ReadLine();
        List<string> words = sentence.Split(' ').ToList();
        List<int> commas = new List<int>();
        int str = 0;
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].Contains(','))
            {
                while (true)
                {
                    int search = words[i].IndexOf(",", str);
                    if (search < 0)
                    {
                        break;
                    }
                    commas.Add(search);
                    str = search + 1;
                }
            }
        }
        words.Reverse();
        sentence = string.Join(" ", words);
        sentence = sentence.Replace(",", "");
        words.Clear();
        words = sentence.Split(' ').ToList();
            for (int i = 0; i < commas.Count; i++)
            {
                words.Insert(commas[i] + 1, ",");
            }
        sentence = string.Join(" ", words);
        string newSent = string.Empty;
        if (sentence.IndexOf('.') >= 0)
        {
            sentence = sentence.Replace(".", "");
            Console.WriteLine(sentence + ".");
        }
        if (sentence.IndexOf('?') >= 0)
        {
            sentence = sentence.Replace("?", "");
            Console.WriteLine(sentence + "?");
        }
        if (sentence.IndexOf('!') >= 0)
        {
            sentence = sentence.Replace("!", "");
            Console.WriteLine(sentence + "!");
        }
    }
}


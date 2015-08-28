//Write a program that sorts an array of strings using the Quick sort algorithm.
using System;
using System.Collections.Generic;
class QuickSor
{
    static void QuickSort(List<string> words)
    {
        if(words.Count < 2)
        {
            return;
        }
        string pivot = words[words.Count / 2];
        List<string> left = new List<string>();
        List<string> right = new List<string>();
        for(int i = 0; i < words.Count; i++)
        {
            if(i == words.Count/2)
            {
                continue;
            }
            if(string.Compare(words[i], pivot)<0)
            {
                left.Add(words[i]);
            }
            else
            {
                right.Add(words[i]);
            }
        }
        QuickSort(left);
        QuickSort(right);
        words.Clear();
        words.AddRange(left);
        words.Add(pivot);
        words.AddRange(right);
    }
    static void Main()
    {
        Console.Write("Enter some words: ");
        string word = Console.ReadLine();
        List<string> words = new List<string>(word.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));
        QuickSort(words);
        for(int i = 0; i < words.Count; i++)
        {
            Console.Write(words[i] + ", ");
        }
        Console.WriteLine();
    }
}

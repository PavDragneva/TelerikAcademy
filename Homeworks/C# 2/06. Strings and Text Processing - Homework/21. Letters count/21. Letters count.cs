using System;
using System.Linq;
using System.Collections.Generic;
//•	Write a program that reads a string from the console and prints all different letters in the 
//  string along with information how many times each letter is found.
class LettersCount
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine().ToLower();
        HashSet<char> letters = new HashSet<char>();
        for(int i = 0; i < text.Length; i++)
        {
            if(text[i] > 96 && text[i] < 123)
            {
                letters.Add(text[i]);
            }
        }
        List<char> letter = new List<char>();
        foreach(char chars in letters)
        {
            letter.Add(chars);
        }
        List<int> counter = new List<int>();
        int coun = 0;
       for(int i = 0; i < letters.Count; i++)
       {
           for(int j = 0; j < text.Length; j++)
           {
               if(text[j] == letter[i])
               {
                   coun++;
               }
           }
           counter.Add(coun);
           coun = 0;
       }
        for(int i = 0; i < counter.Count; i++)
        {
            Console.WriteLine("{0} --> {1}times", letter[i], counter[i]);
        }
    }
}


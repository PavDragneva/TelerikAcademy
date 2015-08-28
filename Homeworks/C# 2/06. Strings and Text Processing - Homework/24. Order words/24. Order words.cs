using System;
using System.Linq;
using System.Collections.Generic;
//•	Write a program that reads a list of words, separated by spaces 
//  and prints the list in an alphabetical order.
class OrderWords
{
    static void Main()
    {
        Console.Write("Enter some words separeted by space: ");
        string wordStr = Console.ReadLine();
        List<string> wordsList = wordStr.Split(' ').ToList();
        wordsList.Sort();
        foreach(string word in wordsList)
        {
            Console.WriteLine(word);
        }
    }
}

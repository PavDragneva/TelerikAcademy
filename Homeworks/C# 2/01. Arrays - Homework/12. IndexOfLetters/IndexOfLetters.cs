//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.
using System;
class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for(int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(65 + i);
        }
        Console.Write("Enter word: ");
        string word = Console.ReadLine().ToUpper();
        int[] wordArr = new int[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            for (int letter = 0; letter < alphabet.Length; letter++)
            {
                if(word[i] == alphabet[letter])
                {
                    wordArr[i] = letter+1;
                }
            }
        }
        for(int i = 0; i < wordArr.Length; i++)
        {
            Console.Write(wordArr[i] + " ");
        }
    }
}


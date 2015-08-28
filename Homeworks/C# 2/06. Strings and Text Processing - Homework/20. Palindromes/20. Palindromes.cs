using System;
using System.Linq;
using System.Collections.Generic;
//•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        List<string> words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        for (int i = 0; i < words.Count; i++)
        {
            string word = words[i];
            int leng = (word.Length-1)/2;
            int count = 0;
            int index = 0;
            int endPointWord = word.Length-1;
            while(count <= leng)
            {
                if(word[index] != word[endPointWord])
                {
                    break;
                }
                else if(index == leng)
                {
                    Console.WriteLine(word);
                }
                index++;
                endPointWord--;
                count++;
            }
        }
    }
}

using System;
//• Write a program that finds how many times a sub-string is contained in a given text 
//(perform case insensitive search).
class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine().ToLower();
        Console.Write("Enter word for searching: ");
        string word = Console.ReadLine().ToLower();
        int count = 0; 
        int strIndex = 0;
        while(true)
        {
            int found = text.IndexOf(word, strIndex);
            if(found < 0)
            {
                break;
            }
            count++;
            strIndex = found+1;
        }
        Console.WriteLine("The substring {0} can be found {1}times in the text.", word, count);
    }
}


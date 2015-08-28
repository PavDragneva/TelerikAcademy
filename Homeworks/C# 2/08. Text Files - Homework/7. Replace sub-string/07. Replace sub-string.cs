using System;
using System.IO;
/*•	Write a program that replaces all occurrences of the sub-string start with 
         *  the sub-string finish in a text file.
          •	Ensure it will work with large files (e.g. 100 MB).*/
class ReplaceSubString
{
    static void Main()
    {
        Console.Write("Enter path to the file: ");
        string path = Console.ReadLine();
        StreamReader reader = new StreamReader(path);
        string text = reader.ReadToEnd();
        string newText = text.Replace("start", "finish");
        reader.Close();
        StreamWriter writer = new StreamWriter(path);
        writer.Write(newText);
        writer.Flush();
        Console.WriteLine("File is written!");
    }
}


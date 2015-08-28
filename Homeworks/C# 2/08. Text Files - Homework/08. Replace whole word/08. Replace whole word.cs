using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
//•	Modify the solution of the previous problem to replace only whole words (not strings).
class ReplaceWholeWord
{
    static void Main()
    {
        Console.Write("Enter path to the file: ");
        string path = Console.ReadLine();
        StreamReader reader = new StreamReader(path);
        List<string> text = reader
            .ReadToEnd()
            .Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        for(int i = 0; i < text.Count; i++)
        {
            if(text[i] == "start")
            {
                text[i] = "finish";
            }
        }
        string newText = string.Join(" ", text).ToString();
        reader.Close();
        StreamWriter writer = new StreamWriter(path);
        writer.Write(newText);
        writer.Flush();
        Console.WriteLine("File is written!");
    }
}


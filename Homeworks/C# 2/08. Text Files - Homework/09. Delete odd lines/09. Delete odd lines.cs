using System;
using System.IO;
using System.Text;
//•	Write a program that deletes from given text file all odd lines.
//•	The result should be in the same file.
class DeleteOddLines
{
    static void Main()
    {
        Console.Write("Enter path to the file: ");
        string path = Console.ReadLine();
        StreamReader reader = new StreamReader(path);
        StringBuilder linesEven = new StringBuilder();
        string line = reader.ReadLine();
        while(line != null)
        {
            line = reader.ReadLine();
            linesEven.AppendLine(line);
            line = reader.ReadLine();
        }
        reader.Close();
        StreamWriter writer = new StreamWriter(path);
        writer.WriteLine(linesEven);
        writer.Flush();
        Console.WriteLine("File is written!");
    }
}


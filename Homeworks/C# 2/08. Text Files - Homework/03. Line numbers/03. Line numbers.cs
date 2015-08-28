using System;
using System.IO;
//•	Write a program that reads a text file and inserts line numbers in front of each of its lines.
//•	The result should be written to another text file.
class LineNumbers
{
    static void Main()
    {
        Console.Write("Enter path to the file: ");
        StreamReader reader = new StreamReader(Console.ReadLine());
        Console.Write("Enter path to the new file: ");
        StreamWriter writer = new StreamWriter(Console.ReadLine());
        string line = reader.ReadLine();
        int counter = 0;
        while(line != null)
        {
            counter++;
            writer.WriteLine("{0} --> {1}", counter, line);
            line = reader.ReadLine();
            writer.Flush();
            Console.WriteLine("File is written!");
        }
    }
}

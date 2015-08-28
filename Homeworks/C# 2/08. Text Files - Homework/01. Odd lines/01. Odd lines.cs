using System;
using System.IO;
//•	Write a program that reads a text file and prints on the console its odd lines.
class OddLines
{
    static void Main()
    {
        Console.Write("Enter path to text file: ");
        StreamReader reader = new StreamReader(Console.ReadLine());
        string oddLines = reader.ReadLine();
        while(oddLines != null)
        {
            Console.WriteLine(oddLines);
            oddLines = reader.ReadLine();
            oddLines = reader.ReadLine();
        }
    }
}


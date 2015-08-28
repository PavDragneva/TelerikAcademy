using System;
using System.IO;
//•	Write a program that concatenates two text files into another text file.
class ConcatenateTextFiles
{
    static void Main()
    {
        Console.Write("Enter path to the first file: ");
        StreamReader readerFirst = new StreamReader(Console.ReadLine());
        string textOne = readerFirst.ReadToEnd();
        Console.Write("Enter path to the second file: ");
        StreamReader readerSecond = new StreamReader(Console.ReadLine());
        string textTwo = readerSecond.ReadToEnd();
        Console.Write("Enter path to the new file: ");
        StreamWriter concatText = new StreamWriter(Console.ReadLine());
        string all = textOne+textTwo;
        concatText.Write(all);
        concatText.Flush();
        Console.WriteLine("File is written!");
    }
}

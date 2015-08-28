using System;
using System.IO;
/*•	Write a program that compares two text files line by line and prints the number of
       *  lines that are the same and the number of lines that are different.
        •	Assume the files have equal number of lines.*/
class CompareTextFiles
{
    static void Main()
    {
        Console.Write("Enter path to the first file: ");
        StreamReader readerFirst = new StreamReader(Console.ReadLine());
        Console.Write("Enter path to the second file: ");
        StreamReader readerSecond = new StreamReader(Console.ReadLine());
        string lineFirst = readerFirst.ReadLine();
        string lineSecond = readerSecond.ReadLine();
        int same = 0;
        int different = 0;
        while(lineFirst != null)
        {
            if(lineFirst == lineSecond)
            {
                same++;
            }
            else
            {
                different++;
            }
            lineFirst = readerFirst.ReadLine();
            lineSecond = readerSecond.ReadLine();
        }
        Console.WriteLine("{0} lines are same.", same);
        Console.WriteLine("{0} lines are different.", different);
    }
}


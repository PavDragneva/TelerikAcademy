using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//•	Write a program that deletes from a text file all words that start with the prefix test.
//•	Words contain only the symbols 0…9, a…z, A…Z, _.
class PrefixTest
{
    static void Main()
    {
        Console.Write("Enter path to the file: ");
         StreamReader inputFile = new StreamReader(Console.ReadLine());
        StringBuilder resultText = new StringBuilder();
            string line = inputFile.ReadLine();
            while (line != null)
            {
                resultText.Append(line);
                resultText.Append(Environment.NewLine);
                line = inputFile.ReadLine();
            }
        Console.WriteLine(resultText);
        string output = string.Empty;
        output = Regex.Replace(resultText.ToString(), @"test(\w+)", " ");
        Console.WriteLine(output);
        Console.Write("Enter path to the new file: ");
        StreamWriter resultFile = new StreamWriter(Console.ReadLine());
        resultFile.Write(output);
        resultFile.Flush();
        Console.WriteLine("File is written!");
    }
}


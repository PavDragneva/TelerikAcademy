﻿//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that 
//prints the entire ASCII table of characters on the console (characters from 0 to 255).
using System;
class PrintASCIITable
{
    static void Main()
    {
    for(int i = 0; i <= 255; i++)
    {
        char ASCII = (char)i;
        Console.WriteLine(ASCII);
    }
    }
}


//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
using System;
class IsoscelesTriangle
{
    static void Main()
    {
        char copyright = (char)184;
        Console.WriteLine("   " + copyright + "   ");
        Console.WriteLine("  " + copyright + " " + copyright + "  ");
        Console.WriteLine(" " + copyright + "   " + copyright + " ");
        Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
    }
}


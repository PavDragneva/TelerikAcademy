//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Array1: ");
        string word1 = Console.ReadLine();
        char[] arr1 = word1.ToCharArray();
        Console.Write("Array2: ");
        string word2 = Console.ReadLine();
        char[] arr2 = word2.ToCharArray();
        if (arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("arr2 is lexicographically earlier.");
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("arr1 is lexicographically earlier.");
                    break;
                }
                else if (i == arr1.Length - 1)
                {
                    Console.WriteLine("They are equal.");
                }
            }
        }
        else if (arr1.Length < arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("arr2 is lexicographically earlier.");
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("arr1 is lexicographically earlier.");
                    break;
                }
                else if (i == arr1.Length - 1)
                {
                    Console.WriteLine("arr1 is lexicographically earlier.");
                }
            }
        }
        else
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine("arr2 is lexicographically earlier.");
                    break;
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("arr1 is lexicographically earlier.");
                    break;
                }
                else if (i == arr2.Length - 1)
                {
                    Console.WriteLine("arr2 is lexicographically earlier.");
                }
            }
        }
    }
}



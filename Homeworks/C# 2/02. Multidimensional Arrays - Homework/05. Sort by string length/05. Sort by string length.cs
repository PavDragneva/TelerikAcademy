using System;
//•	You are given an array of strings. Write a method that sorts the array by the length of its 
//  elements (the number of characters composing them).
class SortByStringLengh
{
    static void SortByLenght(string[] arr)
    {
        for(int i = 0; i < arr.Length-1; i++)
        {
            if(arr[i].Length > arr[i+1].Length)
            {
                string temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
        for(int i = 0; i < arr.Length - 1; i++)
        {
            if(arr[i].Length <= arr[i+1].Length)
            {
                continue;
            }
            else
            {
                SortByLenght(arr);
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter some words: ");
        string words = Console.ReadLine();
        string[] arr = words.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        SortByLenght(arr);
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

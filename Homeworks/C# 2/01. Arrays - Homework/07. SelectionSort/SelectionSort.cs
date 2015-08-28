//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.
using System;
class SelectionSort
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter value for element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int position = 0;
        for (int i = 0; i < n-1; i++)
        {
            int min = int.MaxValue;
            for (int l = i; l < n; l++)
            {
                if(array[l] < min)
                {
                    min = array[l];
                    position = l;
                }  
            }
            int test = array[position];
            array[position] = array[i];
            array[i] = test;
        }
        foreach(int num in array)
        {
            Console.WriteLine(num);
        }
    }
}


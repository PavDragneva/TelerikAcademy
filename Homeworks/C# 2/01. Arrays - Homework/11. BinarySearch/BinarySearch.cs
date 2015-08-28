//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Key = ");
        int key = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value for element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int mid = (array.Length-1) / 2;
        int first = 0;
        int last = n-1;
        while(last >= first)
        {
            if(array[mid] == key)
            {
                Console.WriteLine("{0} --> {1} position", key, mid);
                break;
            }
            else if(key > array[mid])
            {
                if (mid == 1 && array[mid] != key)
                {
                    Console.WriteLine("Not found!");
                    break;
                }
                first = mid + 1;
                mid = (first + last)-1 / 2;
            }
            else if(key < array[mid])
            {
                if (mid == 0 && array[mid] != key)
                {
                    Console.WriteLine("Not found!");
                    break;
                }
                last = mid - 1;
                mid = (first + last)-1 / 2;
            }
        }
    }
}


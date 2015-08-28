//Write a program that reads two integer arrays from the console and compares them element by element.
using System;
class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter the number of elements in array1: ");
        int arr1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of elements in array2: ");
        int arr2 = int.Parse(Console.ReadLine());
        if (arr1 != arr2)
        {
            Console.WriteLine("The arrays are NOT equal.");
        }
        else
        {
            int[] array1 = new int[arr1];
            int[] array2 = new int[arr2];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter value for element {0} of array1: ", i + 1);
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Enter value for element {0} of array2: ", i + 1);
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine("The arrays are NOT equal!");
                    break;
                }
                else if (i == arr1 - 1 && array1[arr1 - 1] == array2[arr2 - 1])
                {
                    Console.WriteLine("The arrays are equal.");
                }
            }
        }
    }
}





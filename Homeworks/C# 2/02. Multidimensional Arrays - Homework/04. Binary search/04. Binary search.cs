using System;
/*•	Write a program, that reads from the console an array of N integers and an integer K, 
       * sorts the array and using the method Array.BinSearch() finds the largest number in the 
       * array which is ≤ K.*/
class BinarySearch
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        if(arr[0] > k)
        {
            Console.WriteLine("Not such number!");
        }
        else
        {
            int max = arr[0];
            int i = 0;
            while(arr[i] <= k)
            {
                max = arr[i];
                i++;
            }
           Console.WriteLine("Largest number is " + arr[Array.BinarySearch(arr, max)]);
        }
    }
}


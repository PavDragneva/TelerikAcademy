//Write a program that sorts an array of integers using the Merge sort algorithm.
using System;
class MergeSort
{
    static void Sort(int[] arr, int left, int right)
    {
        if(left < right)
        {
            int mid = (left + right) / 2;
            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);
            Merge(arr, left, mid, mid+1, right);
        }
    }
    public static void Merge(int[] arr, int left, int midd, int midd1, int right) 
    {
        int oldPosition = left;
        int size = right - left + 1; 
        int[] temp = new int[size]; 
        int i = 0; 
        while (left <= midd && midd1 <= right) 
        {
            if (arr[left] <= arr[midd1]) 
            {
                temp[i++] = arr[left++]; 
            } 
            else
            {
                temp[i++] = arr[midd1++]; 
            } 
        } 
        if (left > midd) 
        {
            for (int j = midd1; j <= right; j++) 
            {
                temp[i++] = arr[midd1++]; 
            } 
        } 
        else 
        { 
            for (int j = left; j <= midd; j++) 
            { 
                temp[i++] = arr[left++]; 
            } 
        } 
        Array.Copy(temp, 0, arr, oldPosition, size); 
    }
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter integer: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Sort(arr, 0, n - 1);
        for(int i = 0; i <n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}


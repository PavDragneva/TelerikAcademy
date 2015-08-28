using System;
/*•	Write a method that return the maximal element in a portion of array of integers starting 
        *  at given index.
         •	Using it write another method that sorts an array in ascending / descending order.*/
class SortingArray
{
    static void SoretArr(int[] arr, bool isDescending)
    {
     int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        int temp = arr[i];
        arr[i] = MaxElement(arr, i);
        for (int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] == arr[i])
            {
                arr[j] = temp;
                break;
            }
        }
            count++;
    }
    if(isDescending == false)
    {
        Array.Reverse(arr);
    }
    }
    static int MaxElement(int[] arr, int strIndex)
    {
        int max = arr[strIndex];
        for(int i = strIndex+1; i < arr.Length; i++)
        {
            if(max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }
    static void Main()
    {
        Console.Write("Enter some nums: ");
        string numString = Console.ReadLine();
        string[] arrStr = numString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrStr.Length];
        for(int i = 0; i < arrStr.Length; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }
        Console.Write("Ascending or descending? - ");
        bool isDescending = true;
        string ask = Console.ReadLine().ToLower();
        if(ask == "ascending")
        {
            isDescending = false;
        }
        else
        {
            isDescending = true;
        }
        SoretArr(arr, isDescending);
        foreach(int nums in arr)
        {
            Console.Write(nums + ", ");
        }
        Console.WriteLine();
    }
}

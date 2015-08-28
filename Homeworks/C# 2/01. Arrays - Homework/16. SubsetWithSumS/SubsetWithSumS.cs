//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
using System;
using System.Linq;
class SubsetWithSumS
{
    static void Main()
    {
        Console.Write("Enter some nums: ");
        string num = Console.ReadLine();
        string[] array = num.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int[] arr = new int[array.Length];
        for(int i = 0; i < array.Length; i++)
        {
            arr[i] = int.Parse(array[i]);
        }
        Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int l = i; l < arr.Length; l++)
            {
                if((sum + arr[l]) > s)
                {
                    continue;
                }
                else if ((sum + arr[l]) <= s)
                {
                    sum += arr[l];
                }
                if (sum == s)
                {
                    Console.WriteLine("yes");
                    break;
                }
            }
            if(sum == s)
            {
                break;
            }
            if (i == arr.Length - 1)
            {
                Console.WriteLine("no");
            }
            sum = 0;
        }
    }
}


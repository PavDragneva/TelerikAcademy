//Write a program that finds the maximal sequence of equal elements in an array.
using System;
class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter some nums: ");
        string numsStr = Console.ReadLine();
        string[] array = numsStr.Split(new char[]{',',' '}, StringSplitOptions.RemoveEmptyEntries); 
        int maxSeq = 0;
        int num = 0;
        int count = 1;
        for(int i = 0; i < array.Length-1; i++)
        {
            if(array[i] == array[i+1])
            {
                count++;
                if(i+1 == array.Length -1)
                {
                    if (count > maxSeq)
                    {
                        maxSeq = count;
                        num = i;
                    }
                }
            }
            else
            {
                if(count > maxSeq)
                {
                    maxSeq = count;
                    num = i;
                }
                count = 1;
            }
        }
        for(int i = 0; i < maxSeq; i++)
        {
            if (i == maxSeq - 1)
            {
                Console.Write(array[num]);
            }
            else
            {
                Console.Write(array[num] + ", ");
            }
        }
        Console.WriteLine();
    }
}


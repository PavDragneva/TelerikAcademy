using System;
//•	Write a method that checks if the element at given position in given array of integers is larger than 
//  its two neighbours (when such exist).
class LargerThanNeighbours
{
    static void CheckIfGraterThanNeighboors(int[] arr, int position)
    {
        if (position < arr.Length && position > 0)
        {
            if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
            {
                Console.WriteLine("The number is greather than neigboors.");
            }
            else
            {
                Console.WriteLine("The number on position {0} is NOT greather than neigboors.", position);
            }

        }
        else
        {
            Console.WriteLine("There is not enought neighboors for check.");
        }
    }
    static void Main()
    {
        Console.Write("Write some nums: ");
        string numString = Console.ReadLine();
        string[] arrString = numString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrString.Length];
        for(int i = 0; i < arrString.Length; i++)
        {
            arr[i] = int. Parse(arrString[i]);
        }
        Console.Write("Position for check: ");
        int position = int.Parse(Console.ReadLine());
        CheckIfGraterThanNeighboors(arr, position);
    }
}


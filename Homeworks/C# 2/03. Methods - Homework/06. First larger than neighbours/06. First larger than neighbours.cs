using System;
/*•	Write a method that returns the index of the first element in array that is larger than
        *  its neighbours, or -1, if there’s no such element.
         •	Use the method from the previous exercise.*/
class FirstLargerThanNeighbours
{
    static void CheckIfGraterThanNeighboors(int[] arr)
    {
        int position = 1;
            for (int i = 1; i < arr.Length-1; i++)
            {
                position = i;
                if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
                {
                    Console.WriteLine(position);
                }
                else if(i == arr.Length - 2)
                {
                    Console.WriteLine(-1);
                }
            }
        }
    static void Main()
    {
        Console.Write("Write some nums: ");
        string numString = Console.ReadLine();
        string[] arrString = numString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[arrString.Length];
        for (int i = 0; i < arrString.Length; i++)
        {
            arr[i] = int.Parse(arrString[i]);
        }
        CheckIfGraterThanNeighboors(arr);
    }
}

using System;
////•	Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that 
//has maximal sum of its elements.
class MaximalSum
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, k];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter number for [{0}, {1}]: ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        int sum = matrix[0, 0] + matrix[1, 0] + matrix[0, 1] + matrix[1, 1] + matrix[0, 2] + matrix[2, 0] + matrix[1, 2] + matrix[2, 1] + matrix[2, 2];
        int max = matrix[0, 0] + matrix[1, 0] + matrix[0, 1] + matrix[1, 1] + matrix[0, 2] + matrix[2, 0] + matrix[1, 2] + matrix[2, 1] + matrix[2, 2];
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row+2, col] + matrix[row + 2, col+2] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row+2, col+1];
                if(sum > max)
                {
                    max = sum;
                }
                sum = matrix[0, 0] + matrix[1, 0] + matrix[0, 1] + matrix[1, 1] + matrix[0, 2] + matrix[2, 0] + matrix[1, 2] + matrix[2, 1] + matrix[2, 2]; 
            }
        }
        Console.WriteLine("Max sum is - {0}", max);
    }
}


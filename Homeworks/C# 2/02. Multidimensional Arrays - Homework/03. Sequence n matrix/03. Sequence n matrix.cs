using System;
/* •	We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
           of several neighbour elements located on the same line, column or diagonal.
         • Write a program that finds the longest sequence of equal strings in the matrix.*/
class SequenceNMatrix
{
   static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, k];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Enter some string for [{0}, {1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
        int count = 1;
        int max = 0;
        string word = string.Empty;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                    while((col < matrix.GetLength(1) - 1)&&matrix[row, col] == matrix[row, col + 1])
                    {
                        count++;
                        col++;
                    }
                while(row < matrix.GetLength(0)-1 && matrix[row, col] == matrix[row+1, col])
                {
                    count++;
                    row++;
                }
                while(row < matrix.GetLength(0)-1 && col < matrix.GetLength(1)-1 && matrix[row, col] == matrix[row+1, col + 1])
                {
                    count++;
                    row++;
                    col++;
                }
                if (max < count)
                {
                    max = count;
                    word = matrix[row, col];
                }
            }
            count = 1;
        }
        for(int i = 0; i < max; i++)
        {
            if(i == max-1)
            {
                Console.Write(word+ " ");
            }
            else
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();
        }
    }
}


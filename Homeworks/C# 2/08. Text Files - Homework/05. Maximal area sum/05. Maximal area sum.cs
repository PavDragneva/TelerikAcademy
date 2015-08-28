using System;
using System.IO;
/*•	Write a program that reads a text file containing a square matrix of numbers.
          •	Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
            o	The first line in the input file contains the size of matrix N.
            o	Each of the next N lines contain N numbers separated by space.
            o	The output should be a single number in a separate text file.*/
class MaximalAreaSum
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter path to the file: ");
        StreamReader lines = new StreamReader(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string line = lines.ReadLine();
            Console.WriteLine(line);
            var nums = line.Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(nums[j]);
            }
        }
        int max = matrix[0, 0] + matrix[0, 1] + matrix[1, 0] + matrix[1, 1];
        for (int i = 0; i < n-1; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if(sum > max)
                {
                    max = sum;
                }
            }
        }
        Console.Write("Enter path to the new fille: ");
        StreamWriter writer = new StreamWriter(Console.ReadLine());
        writer.Write(max);
        writer.Flush();
        Console.WriteLine("File is written!");
    }
}


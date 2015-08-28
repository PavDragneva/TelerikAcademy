using System;
//•	Write a program that fills and prints a matrix of size (n, n) 
class FillTheMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        Console.Write("Choose a method(a, b, c or d): ");
        string choice = Console.ReadLine().ToLower();
        if(choice == "a")
        {
            MethodA(matrix);
        }
        else if(choice == "b")
        {
            MethodB(matrix, n);
        }
        else if (choice == "c")
        {
            MethodC(matrix, n);
        }
        else if (choice == "d")
        {
            MethodD(matrix, n);
        }
        PrintMatrix(matrix); 
    }
    static void MethodA(int[,] matrix)
    {
        int num = 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[col, row] = num++;
            }
        }
    }
    static void MethodB(int[,] matrix, int n)
    {
        int num = 1;
        int temp = n;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                 if(row > 0 && row%2 != 0)
                {
                    while (0 < n)
                    {
                        matrix[--n, row] = num++;
                    }
                    break;
                }
                else
                 {
                     matrix[col, row] = num++;
                 }
            }
            n = temp;
        }
    }
    static void MethodC(int[,] matrix, int n)
    {
        int num = 1;
        int decreese = n * n;
        for (int row = matrix.GetLength(0)-1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if(row+col < n)
                {
                    matrix[row + col, col] = num++;
                }
                if(row+col < n)
                {
                    matrix[col, row+col] = decreese--;
                }
            }
        }
    }
    static void MethodD(int[,] matrix, int n)
    {
        int row = 0;
        int col = 0;
        int lastRow = n - 1;
        int lastCol = n - 1;
        int num = 1;
        do
        {
            for (int i = row; i <= lastRow; i++)
            {
                matrix[i, col] = num++;
            }
            col++;
            for (int i = col; i <= lastCol; i++)
            {
                matrix[lastRow, i] = num++;
            }
            lastRow--;
            for (int i = lastRow; i >= row; i--)
            {
                matrix[i, lastCol] = num++;
            }
            lastCol--;
            for (int i = lastCol; i >= col; i--)
            {
                matrix[row, i] = num++;
            }
            row++;
        } while (num <= n * n);
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}


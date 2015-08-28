using System;
class Matrix<T>
{
    private T[,] matrixA;
    private int rows;
    private int cols;

    public Matrix(int rows, int cols)
    {
        this.MatrixA = new T[rows, cols];
    }

    public T this[int row, int col]
    {
        get
        {
            if (row < 0 || col < 0 || row > this.Rows || col > this.Cols)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            else
            {
                return this.MatrixA[row, col];
            }
        }
        set
        {
            if (row < 0 || col < 0 || row > this.Rows || col > this.Cols)
            {
                throw new ArgumentOutOfRangeException("Invalid index!");
            }
            else
            {
                this.MatrixA[row, col] = value;
            }
        }
    }

    public T[,] MatrixA { get; set; }
    public int Rows { get { return this.MatrixA.GetLength(0); } }
    public int Cols { get { return this.MatrixA.GetLength(1); } }

    public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
    {
        Matrix<T> c = new Matrix<T>(a.Rows, a.Cols);
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < a.Cols; col++)
            {
                try
                {
                    c[row, col] = a[row, col] + (dynamic)b[row, col];
                }
                catch(Exception)
                {
                    Console.WriteLine("Impossible operation!");
                }
            }
        }
        return c;
    }
    public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
    {
        Matrix<T> c = new Matrix<T>(a.Rows, b.Cols);
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < b.Cols; col++)
            {
                try
                {
                    c[row, col] = a[row, col] + (-1 * (dynamic)b[row, col]);
                }
                catch(Exception)
                {
                    Console.WriteLine("Impossible operation!");
                }
            }
        }
        return c;
    }
    public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
    {
        Matrix<T> c = new Matrix<T>(a.Rows, b.Cols);
        int matrixBCols = 0;
        int matrixACols = 0;
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < b.Cols; col++)
            {
                while (true)
                {
                    try
                    {
                        c[row, col] += (a[row, matrixACols] * (dynamic)b[matrixACols, matrixBCols]);
                        matrixACols++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Impossible operation!");
                    }
                    if(matrixACols > a.Rows)
                    {
                        break;
                    }
                }
                matrixACols = 0;
                matrixBCols++;
            }
            matrixBCols = 0;
        }
        return c;
    }
    public static bool operator true(Matrix<T> a)
    {
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < a.Cols; col++)
            {
                if((dynamic)a[row, col] != 0)
                {
                    return true;
                }
            } 
        }
        return false;
    }
    public static bool operator false(Matrix<T> a)
    {
        for (int row = 0; row < a.Rows; row++)
        {
            for (int col = 0; col < a.Cols; col++)
            {
                if ((dynamic)a[row, col] != 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}


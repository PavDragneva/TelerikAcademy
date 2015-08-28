using System;
using System.Collections.Generic;
class Start
{
    static void Main(string[] args)
    {
        //Some tests. You can change values to check the correct work of the program.
        Matrix<int> test = new Matrix<int>(2, 2);
        test[0, 0] = 1;
        test[0, 1] = 2;
        test[1, 0] = 3;
        test[1, 1] = 4;
        Matrix<int> test2 = new Matrix<int>(2, 2);
        test2[0, 0] = 7;
        test2[0, 1] = 8;
        test2[1, 0] = 9;
        test2[1, 1] = 10;
        Matrix<int> c = test + test2;
        for (int row = 0; row < test.Rows; row++)
        {
            for (int col = 0; col < test2.Cols; col++)
            {
                Console.WriteLine(c[row, col]);
            }
        }
    }
}
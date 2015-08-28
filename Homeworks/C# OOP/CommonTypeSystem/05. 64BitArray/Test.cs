//Define a class BitArray64 to hold 64 bit values inside an ulong value.
//Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
using System;
class Test
{
    static void Main()
    {
        BitArray64 a = new BitArray64(8);
        BitArray64 b = new BitArray64(8);
        Console.WriteLine(String.Join("", a.BitArray));
        Console.WriteLine(b[0]);
        b[3] = 1;
        Console.WriteLine(a == b);
        Console.WriteLine(a.Equals(b));
        foreach (var item in a)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
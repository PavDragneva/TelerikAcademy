using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
public class GenericList<T> 
    where T: IComparable
{
    private T[] arr;

    public GenericList(int capacity)
    {
        this.arr = new T[capacity];
    }

    public T[] Arr { get; set; }
    static int index = 0;
    public void AddToGenericList(T element)
    {
        if(index > arr.Length-1)
        {
            T[] temp = new T[2 * arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            this.arr = temp;
        }
        arr[index] = element;
        index++;
    }
    public T AcessByIndex(int index)
    {
        if (index > arr.Length - 1 || index < 0)
        {
            T empt = default(T);
            Console.WriteLine("Invalid value - it's either too big or too small!");
            return empt;
        }
        else
        {
            T element = arr[index];
            return element;
        }
    }
    public void RemoveByIndex(int index)
    {
        if (index > arr.Length - 1 || index < 0)
        {
            Console.WriteLine("Invalid value - it's either too big or too small!");
        }
        else
        {
            T[] temp = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i < index)
                {
                    temp[i] = arr[i];
                }
                else
                {
                    temp[i] = arr[i + 1];
                }
            }
            this.arr = temp;
        }
    }
    public void InsertAtPosition(int position, T element)
    {
        if (position > arr.Length - 1 || position < 0)
        {
            Console.WriteLine("Invalid value - it's either too big or too small!");
        }
        else
        {
            T[] temp = new T[arr.Length + 1];
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i < position)
                {
                    temp[i] = arr[i];
                }
                else if (i == position)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = arr[i - 1];
                }
            }
            this.arr = temp;
        }
    }
    public void ClearingList()
    {
        int i = 0;
        foreach(T elements in arr)
        {
            arr[i] = default(T);
            i++;
        }
    }
    public int FindByValue(T value)
    {
        int count = -1;
        int indexValue = 0;
        foreach(T element in arr)
        {
            count++;
            if(element.Equals(value))
            {
                indexValue = count;
                break;
            }
        }
        return indexValue;
    }
    public T Min()
    {
        T min = arr[0];
        foreach(T element in arr)
        {
            if(element.CompareTo(min) < 0)
            {
                min = element;
            }
        }
        return min;
    }
    public T Max()
    {
        T max = arr[0];
        foreach(T element in arr)
        {
            if(element.CompareTo(max) > 0)
            {
                max = element;
            }
        }
        return max;
    }
    public override string ToString()
    {
        string result = string.Empty;
        foreach(T element in arr)
        {
            result += element + " ";
        }
        return result;
    }
}
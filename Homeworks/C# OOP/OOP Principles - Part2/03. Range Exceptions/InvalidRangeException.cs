using System;
class InvalidRangeException<T>:Exception
{
    private T start;
    private T end;

    public InvalidRangeException(T start, T end, Exception exc, string message)
        :base(message, exc)
    {
        this.Start = start;
        this.End = end;
    }
    public InvalidRangeException(T start, T end, string message)
        :this(start, end, null, message)
    {

    }

    public T Start { get; private set; }
    public T End { get; private set; }
}
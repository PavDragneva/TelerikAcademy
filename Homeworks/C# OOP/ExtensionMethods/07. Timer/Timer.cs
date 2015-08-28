using System;

public delegate void ExecuteSomeMethod(DateTime currentTime);

public class Timer
{
    private int seconds;

    public Timer(int seconds)
    {
        this.Seconds = seconds;
    }

    public int Seconds { get; private set; }

    public static void SayTime(DateTime now)
    {
        Console.WriteLine("It's {0}", now);
    }
}
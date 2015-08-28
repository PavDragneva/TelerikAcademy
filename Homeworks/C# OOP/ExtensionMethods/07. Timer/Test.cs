//Using delegates write a class Timer that can execute certain method at each t seconds.
using System;
using System.Threading;
class Test
    {
        static void Main(string[] args)
        {
            ExecuteSomeMethod exct = new ExecuteSomeMethod(Timer.SayTime);
            int t = 2;
            while (true)
            {
                //Execute every 2 seconds.
                DateTime now = DateTime.Now;
                exct(now);
                Thread.Sleep(t*1000);
            }
        }
    }
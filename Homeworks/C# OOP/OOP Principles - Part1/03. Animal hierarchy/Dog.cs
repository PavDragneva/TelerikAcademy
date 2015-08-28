using System;
public class Dog:Animals, ISound
{
    public Dog(double age, string name, Sex sex)
        :base(age, name, sex)
    {

    }
    public override void MakeSomeNoise()
    {
        Console.WriteLine("Bau-bau");
    }
    public void TakeAWalk()
    {
        Console.WriteLine("Now {0} is happier!", Name);
    }
}
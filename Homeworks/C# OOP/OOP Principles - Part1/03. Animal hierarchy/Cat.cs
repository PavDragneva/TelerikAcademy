using System;
public class Cat:Animals, ISound
{
    public Cat(double age, string name, Sex sex)
        :base(age, name, sex)
    {

    }
    public override void MakeSomeNoise()
    {
        Console.WriteLine("Meow, meow");
    }
    public void Grooming()
    {
        Console.WriteLine("Now {0} is clean!", Name);
    }
}
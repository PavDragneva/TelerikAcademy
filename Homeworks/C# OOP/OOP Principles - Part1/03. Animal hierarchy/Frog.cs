using System;
public class Frog:Animals, ISound
{
    public Frog(double age, string name, Sex sex)
        :base(age, name, sex)
    {

    }
    public override void MakeSomeNoise()
    {
        Console.WriteLine("Krq-kra-krq-lq-lq-lq");
    }
    public void Swim()
    {
        Console.WriteLine("{0} explores the pond");
    }
}
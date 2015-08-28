using System;
using System.Collections.Generic;
public abstract class Animals:ISound
{
    private double age;
    private string name;
    private Sex sex;

    public Animals(double age, string name, Sex sex)
    {
        this.Age = age;
        this.Name = name;
        this.Sex = sex;
    }

    public double Age { get; private set; }
    public string Name { get; private set; }
    public Sex Sex { get; private set; }

    public abstract void MakeSomeNoise();
    public static double AverageAge(IEnumerable<Animals> arr)
    {
        double sum = 0;
        int counter = 0;
        foreach(Animals animal in arr)
        {
            sum += animal.Age;
            counter++;
        }
        return sum / (double)counter;
    }
}
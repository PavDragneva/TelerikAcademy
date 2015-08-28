using System;
public class Tomcat:Cat
{
    public Tomcat(double age, string name, Sex sex)
        :base(age, name, Sex.male)
    {

    }
    public void Sleep()
    {
        Console.WriteLine("{0} is sleeping.");
    }
}
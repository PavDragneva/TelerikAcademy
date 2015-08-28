using System;
public class Kitten:Cat
{
   public Kitten(double age, string name, Sex sex)
       :base(age, name, Sex.female)
    {
        
    }
    public void Play()
   {
       Console.WriteLine("{0} is a bit tired but much happier", Name);
   }
}
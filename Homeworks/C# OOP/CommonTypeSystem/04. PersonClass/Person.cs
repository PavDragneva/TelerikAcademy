using System;
public class Person
{
    private string name;
    private int? age;

    public Person(string name)
    {
        this.Name = name;
    }
    public Person(string name, int? age)
        :this(name)
    {
        this.Age = age;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == null)
            {
                throw new Exception("Missing value for name");
            }
            this.name = value;
        }
    }
    public int? Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Age can't be negative number!");
            }
            this.age = value;
        }
    }
    public override string ToString()
    {
        string newAge = string.Empty;
        if (age == null)
        {
            newAge = "Age is not specified";
        }
        else
        {
            newAge = Age.ToString();

        }
        return string.Format("Name: {0}\nAge: {1}", name, newAge);
    }
}
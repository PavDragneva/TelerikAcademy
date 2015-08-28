using System;
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Student(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public Student(string firstName, string lastName, int age)
        :this(firstName, lastName)
    {
        this.Age = age;
    }

    public override string ToString()
    {
        return string.Format("First name: {0}\nLast name: {1}", FirstName, LastName);
    }
}
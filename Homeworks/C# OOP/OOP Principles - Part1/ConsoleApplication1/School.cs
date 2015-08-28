using System;
using System.Collections.Generic;
public class School
{
    private List<Class> classes = new List<Class>();

    public List<Class> Classes { get; private set; }

    public void AddClass(Class newClass)
    {
        this.Classes.Add(newClass);
    }
    public void RemoveClass(Class someClass)
    {
        this.Classes.Remove(someClass);
    }
}
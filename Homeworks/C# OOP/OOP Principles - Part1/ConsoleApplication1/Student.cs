using System;
using System.Collections.Generic;
public class Student:People,ICommentable
    {
    private int classNumber;

    public Student(string name, int classNumber)
        :base(name)
    {
        this.ClassNumber = classNumber;
    }
    public Student(string name, int classNumber, List<string> comment)
        :base(name, comment)
    {
        this.ClassNumber = classNumber;
    }
    
    public int ClassNumber { get; private set; }

    public override string ToString()
    {
        return string.Format("Name: {0}\nClass number: {1}", this.Name, this.ClassNumber);
    }
    }
using System;
using System.Collections.Generic;
public abstract class People
{
    private string name;

    public People(string name)
    {
        this.Name = name;
    }
    public People(string name, List<string> comments)
        :this(name)
    {
        this.Comments = comments;
    }

    public string Name { get; private set; }
    public List<string> Comments { get; private set; }

    public abstract override string ToString();
    public void AddComment(string text)
    {
        Comments.Add(text);
    }
}
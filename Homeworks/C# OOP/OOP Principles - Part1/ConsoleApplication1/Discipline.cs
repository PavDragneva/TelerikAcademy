using System;
using System.Collections.Generic;
public class Discipline : ICommentable
{
    private string name;
    private int numLectures;
    private int numExrs;

    public Discipline(string name, int numLectures, int numExrs)
    {
        this.Name = name;
        this.NumLectures = numLectures;
        this.NumExrs = numExrs;
    }
    public Discipline(string name, int numLectures, int numExrs, List<string> comments)
        :this(name, numLectures, numExrs)
    {
        this.Comments = comments;
    }

    public string Name { get; private set; }
    public int NumLectures { get; private set; }
    public int NumExrs { get; private set; }
    public List<string> Comments { get; private set; }

    public override string ToString()
    {
        return string.Format("{0}\nNumber of lectures: {1}\nNumber of exercise: {2}", Name, NumLectures, NumExrs);
    }
    public void AddComment(string text)
    {
        Comments.Add(text);
    }
}
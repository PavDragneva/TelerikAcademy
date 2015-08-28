using System;
using System.Collections.Generic;
public class Class:ICommentable
{
    private List<Teacher> teachers = new List<Teacher>();
    private string textId;

    public Class(List<Teacher> teachers, string textId)
    {
        this.Teachers = teachers;
        this.TextId = textId;
    }
    public Class(List<Teacher> teachers, string textId, List<string> comments)
        : this(teachers, textId)
    {
        this.Comments = comments;
    }
    public IEnumerable<Teacher> Teachers
    {
        get
        {
            return this.Teachers = teachers;
        }
        private set
        {
            this.Teachers = value;
        }
    }
    public string TextId { get; private set; }
    public List<string> Comments { get; private set; }

    public void AddTeacher(Teacher newTeacher)
    {
        this.teachers.Add(newTeacher);
    }
    public void RemoveTeacher(Teacher someTeacher)
    {
        this.teachers.Remove(someTeacher);
    }
    public int CountTeachers()
    {
        return this.teachers.Count;
    }
    public void AddComment(string text)
    {
        Comments.Add(text);
    }
}
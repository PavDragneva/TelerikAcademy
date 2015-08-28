using System;
using System.Collections.Generic;
public class Teacher : People, ICommentable
{
    private List<Discipline> disciplines = new List<Discipline>();
    
    public Teacher(string name, List<Discipline> disciplines)
        :base(name)
    {
        this.Disciplines = disciplines;
    }
    public Teacher(string name, List<Discipline> disciplines, List<string> comments)
        :base(name, comments)
    {
        this.Disciplines = disciplines;
    }

    public List<Discipline> Disciplines { get; private set; }

    public void AddDiscipline(Discipline newDisc)
    {
        Disciplines.Add(newDisc);
    }
    public void RemoveDiscipline(Discipline remDisc)
    {
        Disciplines.Remove(remDisc);
    }
    public override string ToString()
    {
            return string.Format("Name: {0}\nTeached disciplines: {1}", this.Name, string.Join(", ", this.Disciplines));
    }
}
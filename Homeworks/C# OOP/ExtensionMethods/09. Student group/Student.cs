using System;
using System.Collections.Generic;
class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string FN { get; private set; }
    public string Tel { get; set; }
    public string Email { get; set; }
    public List<int> Marks { get; private set; }
    public int GroupNumber { get; set; }

    public Student(string firstName, string lastName, string fN, string tel, string email, List<int> marks, int groupNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.FN = fN;
        this.Tel = tel;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
    }

    public override string ToString()
    {
        string marksToSt = string.Join(", ", Marks);
        return string.Format("First name: {0}\nLast name: {1}\nFN: {2}\nTel: {3}\nEmail: {4}\nMarks: {5}\nGroup number: {6}",
            this.FirstName, this.LastName, this.FN, this.Tel, this.Email, marksToSt, this.GroupNumber);
    }
    public static List<Student> ExtractMail(IEnumerable<Student> students, string mail)
    {
        List<Student> result = new List<Student>();
        mail = "@" + mail;
        foreach(Student st in students)
        {
            if(st.Email.Contains(mail))
            {
                result.Add(st);
            }
        }
        return result;
    }
}
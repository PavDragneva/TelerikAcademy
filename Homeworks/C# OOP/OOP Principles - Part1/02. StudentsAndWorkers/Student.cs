public class Student:Human
    {
    private int grade;

    public Student(string firstName, string lastName, int grade)
        :base(firstName, lastName)
    {
        this.Grade = grade;
    }

    public int Grade { get; private set; }

    public override string ToString()
    {
        return string.Format("Name: {0} {1}\nGrade: {2}", this.FirstName, this.LastName, this.Grade);
    }
    }
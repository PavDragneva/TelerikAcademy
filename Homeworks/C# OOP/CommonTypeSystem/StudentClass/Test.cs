namespace StudentClass
{
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone 
//e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of 
//type Student.
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social 
//security number (as second criteria, in increasing order).
    using System;
    using StudentClass.Enums;
    class Test
    {
        static void Main()
        {
            Student student1 = new Student ("Anton", "Dimitrov", "Ivanov", 1497845, "Ul. Briast 13", "099922233", "ADI@abv.bg", 2, Speciality.Statistic, University.TU, Faculty.Mathemathical);
            Student student2 = new Student("Anton", "Dimitrov", "Ivanov", 1497845, "Ul. Briast 13", "099922233", "ADI@abv.bg", 2, Speciality.Statistic, University.TU, Faculty.Mathemathical);
            Console.WriteLine("Student1.Equals(Student2) - {0}", student1.Equals(student2));
            student2.FirstName = "Ivan";
            Console.WriteLine("After changes in student 2 - Student1.Equals(Student2) - {0}", student1.Equals(student2));
            Console.WriteLine("student1 == student2 - {0}", student1 == student2);
            Console.WriteLine("student1 != student2 - {0}", student1 != student2);
            Console.WriteLine("Student1 hask code - {0}", student1.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("02.IClonable");
            Console.WriteLine(new string('-', Console.WindowWidth));
            var clone = student1.Clone() as Student;
            Console.WriteLine("Clone of student1");
            Console.WriteLine(clone);
            Console.WriteLine();
            student1.FirstName = "Darin";
            student1.Course = 3;
            student1.Speciality = Speciality.FinancialManagment;
            Console.WriteLine("Student1 after some changes");
            Console.WriteLine(student1);
            Console.WriteLine();
            Console.WriteLine("Cloned student has not changed");
            Console.WriteLine(clone);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("03.IComparable");
            Console.WriteLine(new string('-', Console.WindowWidth));
            if(student1.CompareTo(student2) > 0)
            {
                Console.WriteLine("student1 < student2");
            }
            else if(student1.CompareTo(student2) < 0)
            {
                Console.WriteLine("student1 > student2");
            }
            else
            {
                Console.WriteLine("student1 = student2");
            }
        }
    }
}
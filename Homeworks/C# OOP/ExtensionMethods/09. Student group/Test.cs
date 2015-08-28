using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    static void Main()
    {
        List<Student> students = new List<Student>()
     {
     new Student("Darina", "Ruseva", "1355062", "02/568406", "dar@abv.bg", new List<int>(){4, 6, 2, 5, 2, 4}, 2),
     new Student("Marian", "Rusev", "1355871", "046/19486", "maro@lqlq.bg", new List<int>(){3, 6, 6, 2, 5, 4}, 2),
     new Student("Anna", "Milova", "1255670", "052/671289", "milova@abv.bg", new List<int>(){5, 6, 4, 6, 5, 4}, 1),
     new Student("Ivan", "Vasilev", "134506", "02/454546", "ivo@lqlq.bg", new List<int>(){5, 6, 3, 5, 3, 4}, 3),
     new Student("Borqna", "Ivova", "1345673", "091/132214", "bob@lq.com", new List<int>(){2, 2, 3, 5, 2, 4}, 1),
     new Student("Ivan", "Milov", "1355680", "04/127869", "ivan.M@lq.com", new List<int>(){5, 6, 4, 5, 3, 4}, 3),
     new Student("Siqna", "Ivova", "1355063", "052/565656", "sisi@abv.bg", new List<int>(){4, 6, 6, 2, 2, 4}, 2),
     new Student("Darin", "Krystev", "1355674", "02/131323", "darko@lq.com", new List<int>(){4, 6, 4, 5, 3, 6}, 1),
     };
        //Task 9
        //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        //Create a List<Student> with sample students. Select only the students that are from group number 2.
        //Use LINQ query. Order the students by FirstName.
        var group2Students = 
                             from st in students
                             where st.GroupNumber == 2
                             orderby st.FirstName
                             select new Student(st.FirstName, st.LastName, st.FN, st.Tel, st.Email, st.Marks, st.GroupNumber);
        Console.WriteLine("Students from group 2 with LINQ");
        Console.WriteLine();
        PrintStudents(group2Students);
        //Task 10
        //Implement the previous using the same query expressed with extension methods.
        group2Students = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
        Console.WriteLine("Students from group 2 with lambda");
        Console.WriteLine();
        PrintStudents(group2Students);
        //Task 11
        //Extract all students that have email in abv.bg.
        //Use string methods and LINQ.
       var mailInAbv = from st in students
                    where st.Email.Contains("@abv.bg")
                    select new Student(st.FirstName, st.LastName, st.FN, st.Tel, st.Email, st.Marks, st.GroupNumber);
        Console.WriteLine("Students with email in abv.bg");
        Console.WriteLine();
        PrintStudents(mailInAbv);
        //Task 12
        //Extract all students with phones in Sofia.
        //Use LINQ.
        var studentsPhoneInSofia = from st in students
                                   where st.Tel[0] == '0' && st.Tel[1] == '2' && st.Tel[2] == '/'
                                   select new Student(st.FirstName, st.LastName, st.FN, st.Tel, st.Email, st.Marks, st.GroupNumber);
        Console.WriteLine("Students with phone in Sofia");
        Console.WriteLine();
        PrintStudents(studentsPhoneInSofia);
        //Task 13
        //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
         //Use LINQ.
        var selectByMarks6 = from st in students
            where st.Marks.Contains(6)
            select new { FullName = st.FirstName + " " + st.LastName, Marks = string.Join(" ", st.Marks)};
        Console.WriteLine("Students with mark 6");
        Console.WriteLine();
        PrintStudents(selectByMarks6);
        //Task 14
        //Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.
        Console.WriteLine("Students with mark 2");
        Console.WriteLine();
        var studentsWith2 = students.Where(st => st.Marks.Where(x => x == 2).Count() == 2);
        PrintStudents(studentsWith2);
        //Task15
        //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        var studentsFrom2006 = from st in students
                               where st.FN.Substring(4, 2) == "06"
                               select st.Marks;
        Console.WriteLine("Students enrolled in 2006");
        Console.WriteLine();
        foreach(var marks in studentsFrom2006)
        {
            Console.WriteLine(string.Join(" ", marks));
            Console.WriteLine();
        }
        //Task18
        //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        //Use LINQ.
        var groupedStudents = from st in students
                              group st by st.GroupNumber into groups
                              from gr in groups
                              select gr;
        Console.WriteLine("Grouped students");
        Console.WriteLine();
        PrintStudents(groupedStudents);
        //Task19
        //Rewrite the previous using extension methods.
        var groupByNum = students.GroupBy(st => st.GroupNumber);
        Console.WriteLine("Grouped students");
        Console.WriteLine();
        foreach (var group in groupByNum)
        {
            Console.WriteLine("Group");
            Console.WriteLine();
            Console.WriteLine(string.Join("\n\n", group));
            Console.WriteLine();
        }
    }
    static void PrintStudents<T>(IEnumerable<T> students)
    {
        foreach (T st in students)
        {
            Console.WriteLine(st);
            Console.WriteLine();
        }
    }
}
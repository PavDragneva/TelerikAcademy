//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
//first name and last name in descending order.
//Rewrite the same with LINQ.
using System;
using System.Linq;
class Test
{
    static void Main()
    {
        Student[] arr = new Student[]
        {
            new Student("Annabell", "John", 26),
            new Student("Marin", "Petrov", 19),
            new Student("Marin", "Ivanov", 25),
            new Student("Maria", "Lilova", 19),
            new Student("Kalin", "Ivanov", 31)
        };
        //Task 3
        var students = 
            from st in arr
            where st.FirstName.ToLower().First() < st.LastName.ToLower().First()
            select new Student(st.FirstName, st.LastName);
        foreach(Student st in students)
        {
            Console.WriteLine(st);
            Console.WriteLine();
        }
        //Task 4
        var studentsByAge =
            from st in arr
            where st.Age >= 18 && st.Age <= 24
            select new Student(st.FirstName, st.LastName);
        Console.WriteLine("Students between 18 and 24 years old");
        Console.WriteLine();
        foreach (Student st in studentsByAge)
        {
            Console.WriteLine(st);
            Console.WriteLine();
        }
        //Task 5
        arr = arr.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).ToArray();
        Console.WriteLine("Sorted");
        Console.WriteLine();
        foreach (Student st in arr)
        {
            Console.WriteLine(st);
            Console.WriteLine();
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
class Test
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
        new Student("Dian", "Ivanov", 5),
        new Student("Alina", "Dimova", 4),
        new Student("Kalin", "Dimitrov", 6),
        new Student("Diana", "Dimitrova", 3),
        new Student("Alex", "Ivanov", 4),
        new Student("Maria", "Bineva", 6),
        new Student("Iliyan", "Rizov", 2),
        new Student("Hristina", "Hristova", 4),
        new Student("Ivan", "Dobrec", 5),
        new Student("Diana", "Ivanova", 6),
        };
        var studentSort = students.OrderBy(st => st.Grade);
        Console.WriteLine("Students sorted by grade");
        Console.WriteLine();
        Console.WriteLine(string.Join("\n\n", studentSort));

        List<Worker> workers = new List<Worker>()
        {
            new Worker("Vasil", "Penev", 200, 8),
            new Worker("Atanas", "Penev", 220, 8),
            new Worker("Karina", "Hristova", 300, 9),
            new Worker("Anastasia", "Paunova", 190, 6),
            new Worker("Ludmil", "Georgiev", 200, 6),
            new Worker("Marina", "Grigorova", 250, 7),
            new Worker("Kristian", "Paunov", 100, 4),
            new Worker("Daniela", "Ivanova", 150, 4),
            new Worker("Kiril", "Irinov", 290, 9),
            new Worker("Anna", "Ilieva", 260, 8),
        };
        var workerMoneyPerHour = from worker in workers
                                 orderby worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay) descending
                                 select new Worker(worker.FirstName, worker.LastName, worker.WeekSalary, worker.WorkHoursPerDay);
        Console.WriteLine();
        Console.WriteLine("Workers ordered by money per hour");
        foreach(Worker worker in workerMoneyPerHour)
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0} {1}\nSalary per hour: {2:0.00}", worker.FirstName, worker.LastName, worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay));
        }
        List<Human> all = new List<Human>();
        all.AddRange(students);
        all.AddRange(workers);
        var sortedByName = all.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
        Console.WriteLine();
        Console.WriteLine("Human ordered by first and last name");
        Console.WriteLine();
        foreach(Human human in sortedByName)
        {
            Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
        }
   }
}
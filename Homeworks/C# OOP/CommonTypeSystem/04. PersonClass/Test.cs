//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.
using System;
class Test
{
    static void Main()
    {
        Person per1 = new Person("Hristina");
        Person per2 = new Person("Daniel", 25);
        Console.WriteLine(per1);
        Console.WriteLine();
        Console.WriteLine(per2);
    }
}
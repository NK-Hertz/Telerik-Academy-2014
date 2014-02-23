using System;
using System.Linq;
/*
 * Write a method that from a given array of students finds all students whose first name is 
 * before its last name alphabetically. Use LINQ query operators.
 */
public class IsFirstNameBeforeLastNameAlph
{
    static void Main()
    {
        var students = new[] 
        {
            new {FirstName = "Dimo", LastName = "Petrov"},
            new {FirstName = "Petar", LastName = "Petrov"},
            new {FirstName = "Ivan", LastName = " Angelov"},
            new {FirstName = "Pesho", LastName = " Zodd"},
            new {FirstName = "Angel", LastName = "Karatistov"},
            new {FirstName = "Simeon", LastName = "Zobav"},
        };

        foreach (var student in students)
	    {
		     Console.WriteLine(student);
	    }

        Console.WriteLine();
        Console.WriteLine();

        var sortedStudents =
           from student in students
           where student.FirstName.CompareTo(student.LastName) == -1
           select student;

        foreach (var item in sortedStudents)
        {
            Console.WriteLine(item);
        }

    }
}
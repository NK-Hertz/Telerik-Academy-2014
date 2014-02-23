using System;
using System.Collections.Generic;
using System.Linq;
/*
 * Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 */
public class StudentsNameBW18And24
{
    static void Main()
    {
        var students = new[]
        {
            new {FirstName = "Dimo", LastName = "Petrov", Age = 16},
            new {FirstName = "Petar", LastName = "Petrov", Age = 19},
            new {FirstName = "Ivan", LastName = " Angelov", Age = 21,},
            new {FirstName = "Pesho", LastName = " Zodd", Age = 18},
            new {FirstName = "Angel", LastName = "Karatistov", Age = 22},
            new {FirstName = "Simeon", LastName = "Zobav", Age = 20},
        };
        var sorted =
            from st in students
            where (st.Age >= 18 && st.Age <= 24)
            select (st.FirstName + " " + st.LastName);


        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}
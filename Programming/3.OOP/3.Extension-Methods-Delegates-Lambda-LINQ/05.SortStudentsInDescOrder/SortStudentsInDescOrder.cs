using System;
using System.Linq;
/*
 * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
 * first name and last name in descending order. Rewrite the same with LINQ.
 */
public class SortStudentsInDescOrder
{
    public static void Main()
    {
        Student[] myClass = 
        {
               new Student("Ivan", "Mihailov"),  
               new Student("Ivan", "Ivanov"),
               new Student("Ivan", "Dimitrov"),
               new Student("Ivan", "Stoianov")
        };

        ClassSorter mySorter = new ClassSorter(myClass);
        mySorter.ShowSortedClass();
    }
}
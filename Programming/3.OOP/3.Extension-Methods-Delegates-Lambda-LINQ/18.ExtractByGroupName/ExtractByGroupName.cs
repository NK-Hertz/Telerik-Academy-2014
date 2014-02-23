/*
 * 18.Create a program that extracts all students grouped by GroupName and then prints 
 * them to the console. Use LINQ.
 */
namespace _18.ExtractByGroupName
{
    using _08.StudentTask;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ExtractByGroupName
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            Student ivan = new Student("Ivan", "Ivanov", "141000", "02325123", "VV@abv.bg", 1);
            students.Add(ivan);
            Student gosho = new Student("Gosho", "Goshev", "141001", "052222222", "TheDarkKnight@abv.bg", 1);
            students.Add(gosho);
            Student pesho = new Student("Pesho", "Mastikata", "141002", "052123634", "OnlyMastika@abv.bg", 2);
            students.Add(pesho);
            Student kiro = new Student("Kiro", "Leshnikov", "141003", "03225123", "Leshnikov@abv.bg", 2);
            students.Add(kiro);
            Student maria = new Student("Maria", "Dimitrova", "141004", "056251231", "mimi123@google.com", 3);
            students.Add(maria);
            Student vanq = new Student("Vanq", "Ivanova", "141005", "032412413", "NaLunataSum@google.com", 2);
            students.Add(vanq);

            var groups = students.GroupBy(student => student.GroupNumber);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine("Group: " + group.Key);
            //    foreach (var name in group)
            //    {
            //        Console.WriteLine("\t{0} {1}", name.FirstName, name.LastName);
            //    }
            //}

            var orderedGroups = students.OrderByGroup();
            foreach (var orderedItems in orderedGroups)
            {
                Console.WriteLine("Group: " + orderedGroups);
                Console.WriteLine("\t{0} {1}", orderedItems.FirstName, orderedItems.LastName);
            }
        }
    }
}

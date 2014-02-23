/*
 * Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>),
 * GroupNumber. Create a List<Student> with sample students. Select only the students that are from 
 * group number 2. Use LINQ query. Order the students by FirstName.
 */
namespace _08.StudentTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentTask
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

            //outputs all students and the information about them
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.ToString());
            //    Console.WriteLine();
            //}

            //only students from group two are printed and sorted by first name
            //LINQ

            //var fromGroupTwo =
            //    students.Where(st => st.GroupNumber == 2)
            //    .OrderBy(st => st.FirstName);
            
            //foreach (var st in fromGroupTwo)
            //{
            //    Console.WriteLine(st.ToString());
            //}

            //10.Implement the previous using the same query expressed with extension methods.
            var groupTwo = students.GetGroup(2);

            //foreach (var st in groupTwo)
            //{
            //    Console.WriteLine(st.ToString());
            //}

            //11.Extract all students that have email in abv.bg. Use string methods and LINQ.
            string withAbvEmails = 
                string.Join(",", students.Where(st => st.Email.EndsWith("@abv.bg")).Select(x => x.FirstName));
            //Console.WriteLine("With abv emails are: {0}", withAbvEmails);
            
            //12.Extract all students with phones in Sofia. Use LINQ.
            string fromSofia = 
                string.Join(",", students.Where(st => st.Tel.StartsWith("02")).Select(x => x.FirstName));
            Console.WriteLine("With phones from Sofia are: {0}", fromSofia);
        }
    }
}

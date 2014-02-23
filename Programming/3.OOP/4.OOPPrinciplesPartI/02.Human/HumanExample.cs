namespace _02.Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HumanExample
    {
        static void Main()
        {
            //students
            List<Student> students = new List<Student>()
            {
                {new Student("Pesho", "Gulekov", 3)},
                {new Student("Dimitur", "Grozev", 5)},
                {new Student("Ivan", "Topuzakov", 1)},
                {new Student("Gosho", "Minkov", 4)},
                {new Student("Stefan", "Arnaudov", 8)},
                {new Student("Maria", "Kurnizova", 9)},
                {new Student("Kurneliq", "Gulekova", 6)},
                {new Student("Ana", "Pironkova", 7)},
                {new Student("Charlotte", "Kalla", 11)},
                {new Student("Lidiq", "Koleva", 2)}
            };

            var orderedByGrade = students.OrderBy(st => st.Grade);
            
            //uncomment to see ordered by grade
            //foreach (var st in orderedByGrade)
            //{
            //    Console.WriteLine(st.ToString());
            //}

            //workers
            List<Worker> workers = new List<Worker>()
            {
                {new Worker("Gulek", "Peshev", 600, 10)},
                {new Worker("Grozio", "Dimitur", 500, 8)},
                {new Worker("Topuzak", "Ivanov", 1000, 12)},
                {new Worker("Minko", "Goshev", 450, 4)},
                {new Worker("Arnaud", "Stefanov", 800, 8)},
                {new Worker("Kurniziq", "Marinova", 750, 9)},
                {new Worker("Zombila", "Kurnelstein", 350, 6)},
                {new Worker("Piron", "Annoff", 700, 8)},
                {new Worker("Khalaman", "Amundi", 1100, 12)},
                {new Worker("Denica", "Atanasova", 2000, 8)},
            };

            // Money Per Hour
            var orderedByMPH = workers.OrderByDescending(work => work.MoneyPerHour());
            //foreach (var work in orderedByMPH)
            //{
            //    Console.WriteLine(work.ToString());
            //}

            //merging lists
            var people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            var sortedByNames = 
                people.OrderBy(person => person.FirstName).ThenBy(person => person.LastName);

            foreach (var person in sortedByNames)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}

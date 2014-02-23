namespace _1.SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class SchoolExample
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "1001211101");
            Student gosho = new Student("Gosho", "1001211102");
            Student ivo = new Student("ivo", "1001211103");
            Student losho = new Student("losho", "1001211104");
            Student trosho = new Student("trosho", "1001211105");

            SchoolClass alpha = new SchoolClass("alpha");
            alpha.AddStudent(pesho);
            alpha.AddStudent(gosho);

            //uncomment to get error for un-uniqueness
            //SchoolClass Alpha = new SchoolClass("Alpha");

            SchoolClass beta = new SchoolClass("beta");
            beta.AddStudent(ivo);

            SchoolClass omega = new SchoolClass("omega");
            omega.AddStudent(losho);
            omega.AddStudent(trosho);

            string allClasses = SchoolClass.GetClasses();
            //Console.WriteLine(allClasses);

            //omega.GetAllStudents();

            Teacher bonaparte = new Teacher("Napoleon Bonaparte");
            Teacher caeser = new Teacher("Gaius Julius Caesar");
            Teacher aristotel = new Teacher("Aristotle");
            Teacher house = new Teacher("House");
            
            alpha.AddTeacher(bonaparte);
            alpha.AddTeacher(aristotel);
            beta.AddTeacher(house);
            omega.AddTeacher(caeser);
            //testing teacher methods
            //alpha.GetAllTeachers();

            Discipline history = new Discipline("History", 23, 44);
            Discipline philosphy = new Discipline("Philosophy", 100, 10);
            Discipline medicine = new Discipline("Medicine", 150, 150);

            house.AddDiscipline(medicine);
            house.AddDiscipline(philosphy);
            aristotel.AddDiscipline(philosphy);
            bonaparte.AddDiscipline(history);
            caeser.AddDiscipline(history);
            
            //house.GetAllDisciplines();


            alpha.AddComment("Why did Aristotel become a philosopher? Answer : He had a bad wife.");
            //alpha.GetComment();

            beta.AddComment("Why does House have 1 student? Cuz he is irritating motherfucker!");
            //beta.GetComment();

            trosho.AddComment("Will be a demolitian genius!");
            //trosho.GetComment();

            house.AddComment("House for president!");
            //house.GetComment();

        }
    }
}

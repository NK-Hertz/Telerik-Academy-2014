namespace _1.SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private List<Discipline> disciplines;
        private string comment = "";

        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }

        public void GetAllDisciplines()
        {
            Console.WriteLine("Disciplines of " + this.Name + " :");
            foreach (var item in disciplines)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

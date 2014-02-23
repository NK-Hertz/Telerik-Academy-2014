namespace _02.Human
{
    using System;
    using System.Collections.Generic;
   
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 1 and 12!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.grade;
        }
    }
}

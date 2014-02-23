namespace _1.SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment = "";

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("Number of Lectures can NOT be negative or equal to zero!");
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("Number of Exercises can NOT be negative or equal to zero!");
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
        }

        public override string ToString()
        {
            return this.name + " / " + this.numberOfLectures + " / " + this.numberOfExercises;
        }

        public void AddComment(string comment)
        {
            if (string.IsNullOrEmpty(comment))
            {
                throw new ArgumentNullException("This is not a valid comment!It should not be a empty or null!");
            }
            else
            {
                this.comment = comment;
            }
        }

        public void GetComment()
        {
            Console.WriteLine(this.comment);
        }
    }
}

namespace SchoolExample
{
    using System;

    public class Student
    {
        private readonly int MaxStudentCount = 99999;
        private static int currentStudentID = 9999;
        private string name;
        private int uniqueNumber;

        public Student(string name)
        {
            this.Name = name;
            this.UniqueNumber = currentStudentID++;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null or empty");
                }
                else
                {
                    this.name = value;
                }
            } 
        }
        public int UniqueNumber 
        {
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                if (MaxStudentCount < value)
                {
                    throw new ArgumentOutOfRangeException("Max number of students reached");
                }
                else
                {
                    this.uniqueNumber = value;
                }
            }
        } 
    }
}

namespace SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private readonly int MaxStudentCount = 29;
        private IList<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
            this.StudentsCount = 0;
        }

        public string Name { get; private set; }

        public IList<Student> Students
        {
            get 
            {
                return new List<Student>(students);           
            }
        }

        //it has to be private set but ill leave it for testing
        public int StudentsCount { get; set; } 

        public void AddStudent(Student student)
        {
            bool isCourseFull = this.CheckIfCourseIsFull();
            if (!isCourseFull)
            {
                this.students.Add(student);
                this.StudentsCount++;
            }
            else
            {
                //Console.WriteLine("Course is full!");
                throw new ArgumentOutOfRangeException("Course is full!");
            }
            
        }

        public void Remove(Student student)
        {
            if (student != null)
            {
                this.students.Remove(student);
                this.StudentsCount--;
            }
            else
            {
                throw new NullReferenceException("Student does not exist!");
            }
            
        }

        public bool CheckIfCourseIsFull()
        {
            bool isCourseFull = false;
            if (this.StudentsCount > MaxStudentCount)
            {
                isCourseFull = true;
            }
            
            return isCourseFull;
        }
    }
}

namespace SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private IList<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
        }

        public IList<Course> Courses 
        {
            get
            {
                return new List<Course>(courses);
            }
        }

        public string Name { get; private set; }

        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course != null)
            {
                this.courses.Remove(course);
            }
            else
            {
                throw new NullReferenceException("Course does not exist");
            }
        }
    }
}

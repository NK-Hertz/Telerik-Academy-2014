namespace _1.SchoolExample
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class SchoolClass : IComment
    {
        private string uniqueTextID;
        private static List<string> schoolClassesID = new List<string>();
        private List<Teacher> teachers;
        private List<Student> students;
        private string comment = "";

        public SchoolClass(string uniqueTextID)
        {
            this.UniqueTextID = uniqueTextID;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public string UniqueTextID
        {
            get { return this.uniqueTextID; }
            set 
            {
                //validating an unique name will be given
                if (schoolClassesID.Contains(value.ToUpper()))
                {
                    throw new Exception
                        ("The class identifier must be unique. [" + value + "] is already taken!");
                }
                else
                {
                    //adding the class to the list of classes
                    this.uniqueTextID = value;
                    schoolClassesID.Add(this.uniqueTextID.ToUpper());
                }
            }
        }

        //students methods
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        //getting all students from certain class
        public void GetAllStudents()
        {
            Console.WriteLine("Students in " + this.uniqueTextID + " Class: ");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //Teacher methods
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void GetAllTeachers()
        {
            Console.WriteLine("Teachers for " + this.uniqueTextID + " Class: ");
            foreach (var item in teachers)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //getting all school classes
        public static string GetClasses()
        {
            return string.Join(" ", schoolClassesID);
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

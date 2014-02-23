namespace _08.StudentTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, string fn,string tel, string email, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            List<int> Marks = new List<int>();
        }

        public virtual string ToString()
        {
            return "First Name: " + this.FirstName + "\n" + "Last Name: " + this.LastName
                + "\n" + "FN: " + this.FN + "\n" + "Tel : " + this.Tel + "\n" + "Email: " + this.Email + "\n" + "Group Number: " +
                this.GroupNumber + "\n";
            /* + "Marks: " + this.Marks*/
        }


    }
}

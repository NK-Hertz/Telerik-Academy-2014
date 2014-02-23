namespace _1.SchoolExample
{
    using System;
    using System.Collections.Generic;

    public class Student : Person
    {
        private string uniqueID;
        private static List<string> studentIDS = new List<string>();
        private string comment = "";

        public Student(string name, string uniqueID)
            : base(name)
        {
            this.UniqueID = uniqueID;
        }

        public string UniqueID
        {
            get { return this.uniqueID; }
            set
            {
                if (studentIDS.Contains(value))
                {
                    throw new ArgumentException("This ID " + value + " is already taken!You must choose an unique one!");
                }
                else
                {
                    this.uniqueID = value;
                    studentIDS.Add(this.uniqueID);
                }
            }
        }

        public override string ToString()
        {
            return this.Name + " " + this.uniqueID ;
        }
    }
}

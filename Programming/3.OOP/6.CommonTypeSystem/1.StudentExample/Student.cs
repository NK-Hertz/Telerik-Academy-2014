using System;

//Enumerators
public enum University
{
    SU, PU, TU, UNSS, AU
}

public enum Specialty
{ 
    Matematics, Informatics, Iconomics, Hardware, Phisics
}

public enum Faculty
{
    FMI, Business, Phisics
}


//IClonable, IComparable<Student>
public class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public int SSN { get; set; }

    public string Address { get; set; }

    public string MobilePhone { get; set; }

    public string Email { get; set; }

    public int Course { get; set; }

    public Specialty Specialty { get; set; }

    public University University { get; set; }

    public Faculty Faculty { get; set; }

    public Student(string firstName, string middleName, string lastName, int ssn) : this(firstName, middleName, lastName, ssn, null, null, null, 0, 0, 0, 0)
    {
    }

    public Student(string firstName, string middleName, string lastName, int ssn,
        string address, string mobilePhone, string email, int course,
        Specialty Specialty, University university, Faculty faculty) 
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Address = address;
        this.MobilePhone = mobilePhone;
        this.Email = email;
        this.Course = course;
        this.Specialty = Specialty;
        this.University = university;
        this.Faculty = faculty;
    }

    //ToString, Equals, ==, != , GetHashCode
    // are overridden
    public override string ToString()
    {
        string newOrder = String.Format("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nSSN: {3}\nAddress Name: {4}\nMobile Phone: {5}\nEmail: {6}\nCourse: {7}\nSpecialty: {8}\nUniversity: {9}\nFaculty: {10}\n",
            this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
            this.MobilePhone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);

        return newOrder;
    }
  
    public override bool Equals(object param)
    {
        Student student = param as Student;
  
        if (student == null)
        {
            return false;
        }
  
        if (!Object.Equals(this.FirstName, student.FirstName))
        {
            return false;
        }
  
        if (!Object.Equals(this.LastName, student.LastName))
        {
            return false;
        }
        if (this.SSN != student.SSN)
        {
            return false;
        }
  
        return true;
    }
  
    public static bool operator ==(Student student1, Student student2)
    {
        return Student.Equals(student1, student2);
    }
  
    public static bool operator !=(Student student1, Student student2)
    {
        return !(Student.Equals(student1, student2));
    }

    public override int GetHashCode()
    {
        return LastName.GetHashCode() ^ SSN.GetHashCode();
    }

    //Student Cloning
    public Student Clone()
    {
        Student clone = new Student(
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.SSN,
            this.Address,
            this.MobilePhone,
            this.Email,
            this.Course,
            this.Specialty,
            this.University,
            this.Faculty);

        return clone;
    }

    object ICloneable.Clone()
    {
        return this.Clone();
    }


    //Comparing method
    public int CompareTo(Student student)
    {
        if (this.LastName != student.LastName)
        {
            return string.Compare(this.LastName, student.LastName);
        }
        if (this.FirstName != student.FirstName)
        {
            return string.Compare(this.FirstName , student.FirstName);
        }
        if (this.SSN != student.SSN )
        {
            return this.SSN - student.SSN;
        }

        return 0;
    }
}
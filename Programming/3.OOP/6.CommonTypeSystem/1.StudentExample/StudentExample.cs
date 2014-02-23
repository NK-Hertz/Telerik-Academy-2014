using System;
/*
 * 1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, 
 * mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
 * Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 
 * 2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new 
 * object of type Student.
 * 
 * 3.Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
 * and by social security number (as second criteria, in increasing order)
 */

class StudentExample
{
    static void Main()
    {
        Student Kiritakcho = new Student("Kiritakcho", "Muffof", "Shmindel",12314213);

        Student Harabakcho = new Student("Harabakcho", "Hold ma pudel", "La Bamba", 12314214);
        Harabakcho.University = University.TU;
        Harabakcho.Specialty = Specialty.Hardware;
        Harabakcho.Faculty = Faculty.Phisics;

        //printing info
        Console.WriteLine(Kiritakcho);
        Console.WriteLine(Harabakcho);

        Console.WriteLine("Are Kiritakcho and Harabakcho realy one person: ");
        Console.WriteLine(Kiritakcho == Harabakcho);

        Console.WriteLine("Get Harabakcho`s Hash Code please: {0}", Harabakcho.GetHashCode());
        Console.WriteLine();

        //cloning Harabakcho and modeling it to version TWO
        var HarabakTwo = Harabakcho.Clone();
        HarabakTwo.FirstName = "HarabakTwo";
        Console.WriteLine(HarabakTwo);

        //comparing the three students, for better understanding change names
        Console.WriteLine(Harabakcho.CompareTo(Kiritakcho)); // La Bamba is before Shmindel, so it returns -1
        Console.WriteLine(HarabakTwo.CompareTo(Harabakcho)); // HarabakTwo is after HarabakCHO, so it returns 1

    }
}
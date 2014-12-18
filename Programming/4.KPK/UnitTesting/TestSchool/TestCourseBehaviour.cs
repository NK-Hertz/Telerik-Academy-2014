namespace TestSchool
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolExample;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class TestCourseBehaviour
    {
        [TestMethod]
        public void TestCourseAddStudent()
        {
            Student misho = new Student("Misho");
            Course english = new Course("English");
            english.AddStudent(misho);
            int studentCount = 1;
            Assert.AreEqual(studentCount, english.StudentsCount, "Student count is different");
        }

        [TestMethod]
        public void TestCourseAddStudentWhenMaxedOut()
        {
            Course english = new Course("English");
            english.StudentsCount = 30;
            int studentCount = 30;
            Assert.AreEqual(studentCount, english.StudentsCount, "Student count is different");
        }

        [TestMethod]
        public void TestCourseRemoveStudent()
        {
            Course english = new Course("English");
            Student misho = new Student("Misho");
            english.AddStudent(misho);
            english.Remove(misho);
            Assert.AreEqual(0, english.StudentsCount, "Student count is different!");
        }

        [TestMethod]
        public void TestCourseIfFullWith15Students()
        {
            Course english = new Course("English");
            english.StudentsCount = 15;
            bool courseFull = english.CheckIfCourseIsFull();
            Assert.IsFalse(courseFull);
        }

        [TestMethod]
        public void TestCourseIfFullWith30Students()
        {
            Course english = new Course("English");
            english.StudentsCount = 30;
            bool courseFull = english.CheckIfCourseIsFull();
            Assert.IsTrue(courseFull);
        }

        //just to clarify again 
        //course.studentsCount can not be negative in the 
        // this is just for the sake of testing
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCourseIfFullWithNegativeStudents()
        {
            Course english = new Course("English");
            english.StudentsCount = -5;
            bool courseFull = english.CheckIfCourseIsFull();
            Assert.IsFalse(courseFull);
        }

        [TestMethod]
        public void TestCourseGetStudents()
        {
            //how to test this
            Course english = new Course("English");
            Student misho = new Student("Misho");
            english.AddStudent(misho);
            List<Student> testList = new List<Student>();
            testList.Add(misho);
            Assert.AreEqual(testList[0], english.Students[0],
                "Students in course are not the same");
            //CollectionAssert.AreEqual(testList, english.Students,
                //"Students in course are not the same");
        }
    }
}

namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolExample;

    [TestClass]
    public class TestStudentBehaviour
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentEmptyName()
        {
            string emptyName = "";
            Student misho = new Student("");
            Assert.AreSame(emptyName, misho.Name, "Names are different");
        }

        //Testing StudentID isn`t done because it`s made 
        //static and not an input value

        [TestMethod]
        public void TestStudentGetName()
        {
            Student misho = new Student("Misho");
            string nameOfStudent = "Misho";
            Assert.AreSame(nameOfStudent, misho.Name, "Names are different!");
        }
        
        [TestMethod]
        public void TestStudentGetUniqueNumber()
        {
            Student misho = new Student("Misho");
            int uniqueId = 10000;
            Assert.AreEqual(uniqueId, misho.UniqueNumber, "Student Unique Number are different!");
        }

    }
}

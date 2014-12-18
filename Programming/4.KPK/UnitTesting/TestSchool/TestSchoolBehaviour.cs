namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolExample;

    [TestClass]
    public class TestSchoolBehaviour
    {
        [TestMethod]
        public void TestSchoolAddCourse()
        {
            Course english = new Course("English");
            School hornsworth = new School("Hornsworth High");
            hornsworth.AddCourse(english);
            int cousesCount = 1;
            Assert.AreEqual(cousesCount, hornsworth.Courses.Count,
                "Courses count is different!");
        }

        [TestMethod]
        public void TestSchoolRemoveCourse()
        {
            Course english = new Course("English");
            School hornsworth = new School("Hornsworth High");
            hornsworth.AddCourse(english);
            hornsworth.RemoveCourse(english);
            int cousesCount = 0;
            Assert.AreEqual(cousesCount, hornsworth.Courses.Count,
                "Courses count is different!");
        }
    }
}

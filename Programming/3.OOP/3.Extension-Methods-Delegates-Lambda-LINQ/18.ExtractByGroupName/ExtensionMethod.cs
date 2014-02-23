namespace _18.ExtractByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _08.StudentTask;

    public static class ExtensionMethod
    {
        public static IEnumerable<Student> OrderByGroup(this IEnumerable<Student> students)
        {
            var groups = students.GroupBy(student => student.GroupNumber, student => student.FirstName);
            return (IEnumerable<Student>)groups;
        }
    }
}

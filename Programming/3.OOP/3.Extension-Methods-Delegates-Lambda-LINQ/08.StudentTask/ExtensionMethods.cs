namespace _08.StudentTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionMethods
    {
        public static IEnumerable<Student> GetGroup(this IEnumerable<Student> students, int groupNumber)
        {
            var group = students.Where(st => st.GroupNumber == groupNumber).OrderBy(st => st.FirstName);
            return group;
        }
    }
}

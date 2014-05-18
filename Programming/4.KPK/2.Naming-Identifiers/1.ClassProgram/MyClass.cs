namespace _1.ClassProgram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MyClass
    {
        //Refactor the following examples to produce code with well-named C# identifiers:

        public const int MAX_COUNT = 6;
        public class InnerClass
        {
            public void ConvertBoolToString(bool isTrue)
            {
                string boolToString = isTrue.ToString();
                Console.WriteLine(boolToString);
            }
        }

        public static void TestConvertBoolToString()
        {
            InnerClass innerClassInstance = new InnerClass();
            innerClassInstance.ConvertBoolToString(true);
        }
    }
}

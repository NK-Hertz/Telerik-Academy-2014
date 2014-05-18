
//Refactor the following examples to produce code with well-named identifiers in C#:

namespace _2.HumanCreater
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum Sex { UltraBatka, QkaMacka };

    public class Human
    {
        public Sex HumanSex { get; set; }
        public string HumanName { get; set; }
        public int HumanAge { get; set; }

        public void CreateHuman(int humanNumber)
        {
            Human resultHuman = new Human();
            resultHuman.HumanAge = humanNumber;
            if (humanNumber % 2 == 0)
            {
                resultHuman.HumanName = "Батката";
                resultHuman.HumanSex = Sex.UltraBatka;
            }
            else
            {
                resultHuman.HumanName = "Мацето";
                resultHuman.HumanSex = Sex.QkaMacka;
            }
        }


    }
}

namespace _3.AnimalExample
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        { }

        public override void ProduceSound()
        {
            Console.WriteLine(Name + ": Roar!");
        }
    }
}

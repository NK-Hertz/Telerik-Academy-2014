namespace _3.AnimalExample
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        { }

        public override void ProduceSound()
        {
            Console.WriteLine(Name + ": Meow");
        }
    }
}

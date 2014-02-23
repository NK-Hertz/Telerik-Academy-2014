namespace _3.AnimalExample
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        { }

        public override void ProduceSound()
        {
            Console.WriteLine(Name + ": Hello, my baby Hello, my honey Hello, my ragtime gal!");
        }
    }
}

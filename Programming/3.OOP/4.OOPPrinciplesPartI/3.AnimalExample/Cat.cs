namespace _3.AnimalExample
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        { }

        public override void ProduceSound()
        {
            Console.WriteLine(Name + ": Nyan Nyan Nyan Nyan");
        }
    }
}
